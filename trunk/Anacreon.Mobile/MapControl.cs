using System;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using System.Collections.Generic;

using Anacreon.Engine;

namespace Anacreon.Mobile
{
	public partial class MapControl : UserControl
	{
		Image     m_curmap;
		MenuItem  m_item_probe;
		MenuItem  m_item_csep;
		MenuItem  m_item_cancel;
		Image     m_off_img;
		Graphics  m_off_g;

		public MapControl(Universe universe)
		{
			Universe  = universe;
			LastPoint = Point.Empty;
			Offset    = Size.Empty;
			Brushes   = new Brushes();

			InitializeComponent();

			Disposed += (s, e) =>
				{
					Brushes.Dispose();

					if( m_off_img != null )
						m_off_img.Dispose();

					if( m_off_g != null )
						m_off_g.Dispose();
				};

			Resize += (s, e) =>
				{
					if( m_off_img != null )
						m_off_img.Dispose();

					if( m_off_g != null )
						m_off_g.Dispose();

					m_off_img = new Bitmap(ClientRectangle.Width, ClientRectangle.Height);
					m_off_g   = Graphics.FromImage(m_off_img);
				};

			ContextMenu = new ContextMenu();

			using( var g = CreateGraphics() )
			{
				var cs = g.MeasureString("#", Font);
				CharacterSize = new Size(Convert.ToInt32(cs.Width), Convert.ToInt32(cs.Height));
			}

			//m_curmap      = new Bitmap(((Universe.Sectors.GetLength(0) * 3) + 2) * CharacterSize.Width, (Universe.Sectors.GetLength(1) + 2) * CharacterSize.Height, PixelFormat.Format16bppRgb555);
			m_curmap      = new Bitmap((Universe.Sectors.GetLength(0) * 3) * CharacterSize.Width, Universe.Sectors.GetLength(1) * CharacterSize.Height);
			m_item_probe  = CreateMenuItem("Send Probe", Menu_SendProbe);
			m_item_csep   = CreateMenuItem("-",          null);
			m_item_cancel = CreateMenuItem("Cancel",     null);

			KeyDown += (s, e) =>
				{
					if( e.KeyCode == Keys.Up )
					{
						Offset = new Size(Offset.Width + 1, Offset.Height);
						Invalidate();
					}
				};
		}

		protected Universe Universe { get; private set; }

		protected Size CharacterSize { get; private set; }

		private Point LastPoint { get; set; }

		private Size Offset { get; set; }

		protected Point? SelectedSector { get; set; }

		private bool TrackSkew { get; set; }

		private bool IsMoving { get; set; }

		private Brushes Brushes { get; set; }

		protected override void OnPaint(PaintEventArgs e)
		{
			this.SuspendLayout();

			var sect_x = Offset.Width / (CharacterSize.Width * 3);
			var off_x  = (sect_x * CharacterSize.Width * 3) - Offset.Width;
			var drw_x  = Math.Ceiling(ClientRectangle.Width / (CharacterSize.Width * 3));

			var sect_y = Offset.Height / CharacterSize.Height;
			var off_y  = (sect_y * CharacterSize.Height) - Offset.Height;
			var drw_y  = Math.Ceiling(ClientRectangle.Height / CharacterSize.Height);

			var dcnt = 0;

			var sw = System.Diagnostics.Stopwatch.StartNew();

			// draw (part of) the off-screen image onto the screen
			//e.Graphics.DrawImage(m_curmap, 0, 0, new Rectangle(Offset.Width, Offset.Height, ClientRectangle.Width, ClientRectangle.Height), GraphicsUnit.Pixel);

			//e.Graphics.Clear(Color.Black);
			m_off_g.Clear(Color.Black);

			// 165 draws by default
			// 140 draws by combining
			//  39 draws by drawing grid early
			//  30 draws by grouping by brush per-line

			/*for( var y = 0; y < drw_y + 1; y++ )
			{
				var y_pos = (y * CharacterSize.Height) + off_y;

				for( var x = 0; x < drw_x + 1; x++ )
				{
					var these_chars = GetSectorChars(Universe, x + sect_x, y + sect_y, Brushes);
					var x_pos       = x * CharacterSize.Width * 3;

					if( these_chars[0].Brush == these_chars[1].Brush && these_chars[0].Brush == these_chars[2].Brush )
					{
						if( these_chars[0].Character != null || these_chars[1].Character != null || these_chars[2].Character != null )
						{
							var s = string.Concat(these_chars[0].Character ?? " ", these_chars[1].Character ?? " ", these_chars[2].Character ?? " ");

							dcnt++;

							m_off_g.DrawString(s, Font, these_chars[0].Brush, x_pos + (CharacterSize.Width * 0) + off_x, y_pos);
						}
					}
					else
					{
						if( these_chars[0].Character != null )
						{
							dcnt++;
							m_off_g.DrawString(these_chars[0].Character, Font, these_chars[0].Brush, x_pos + (CharacterSize.Width * 0) + off_x, y_pos);
						}

						if( these_chars[1].Character != null )
						{
							dcnt++;
							m_off_g.DrawString(these_chars[1].Character, Font, these_chars[1].Brush, x_pos + (CharacterSize.Width * 1) + off_x, y_pos);
						}

						if( these_chars[2].Character != null )
						{
							dcnt++;
							m_off_g.DrawString(these_chars[2].Character, Font, these_chars[2].Brush, x_pos + (CharacterSize.Width * 2) + off_x, y_pos);
						}
					}
				}
			}*/

			var swb = new System.Diagnostics.Stopwatch();
			var sws = new System.Diagnostics.Stopwatch();

			for( var y = 0; y < drw_y + 1; y++ )
			{
				var y_pos = (y * CharacterSize.Height) + off_y;
				var sects = new List<SectorChar[]>();

				for( var x = 0; x < drw_x + 1; x++ )
					sects.Add(GetSectorChars(Universe, x + sect_x, y + sect_y, Brushes));

				var chars = sects.SelectMany(a => a);

				swb.Start();
				var brushes = chars.Where(c => c.Brush != null).Select(c => c.Brush).Distinct().ToArray();
				swb.Stop();

				foreach( var b in brushes )
				{
					sws.Start();
					var s = new string(chars.Select(c => c.Brush == b && c.Character != '\0' ? c.Character : ' ').ToArray());
					//var s = new string(chars.Select(c => c.Brush == b && c.Character != null ? c.Character[0] : ' ').ToArray());
					//var s = string.Concat(chars.Select(c => c.Brush == b && c.Character != null ? c.Character : " ").ToArray());
					sws.Stop();

					dcnt++;
					m_off_g.DrawString(s, Font, b, off_x, y_pos);
				}
			}

			e.Graphics.DrawImage(m_off_img, 0, 0);

			sw.Stop();

			using( var brush = new SolidBrush(Color.Blue) )
			using( var font = new Font(Font.Name, Font.Size + 4, FontStyle.Bold) )
			{
				e.Graphics.DrawString(string.Format("char: {0}x{1}", CharacterSize.Width, CharacterSize.Height), font, brush, 0, 140);
				e.Graphics.DrawString(string.Format("clirect: {0}x{1}", ClientRectangle.Width, ClientRectangle.Height), font, brush, 0, 170);
				e.Graphics.DrawString(string.Format("map: {0}x{1}", m_curmap.Width, m_curmap.Height), font, brush, 0, 200);
				e.Graphics.DrawString(string.Format("time: {0} {1} {2}", sw.ElapsedMilliseconds, swb.ElapsedMilliseconds, sws.ElapsedMilliseconds), font, brush, 0, 230);
				e.Graphics.DrawString(string.Format("offset: h {0} v {1}", Offset.Width, Offset.Height), font, brush, 0, 260);
				e.Graphics.DrawString(string.Format("last point: {0}, {1}", LastPoint.X, LastPoint.Y), font, brush, 0, 290);
				e.Graphics.DrawString(string.Format("dcnt: {0}", dcnt), font, brush, 0, 320);

				if( SelectedSector != null )
				{
					var coord_x = (((SelectedSector.Value.X * 3) + 1) * CharacterSize.Width) - Offset.Width;
					var coord_y = ((SelectedSector.Value.Y) * CharacterSize.Height) - Offset.Height;

					e.Graphics.DrawString(string.Format("sel point: {0}, {1}", SelectedSector.Value.X, SelectedSector.Value.Y), font, brush, 0, 350);
					e.Graphics.DrawString(string.Format("sel coord: {0}, {1}", coord_x, coord_y), font, brush, 0, 380);

					e.Graphics.DrawString("┌ ┐", Font, Brushes.White, coord_x, coord_y);
					e.Graphics.DrawString("└ ┘", Font, Brushes.White, coord_x, coord_y + (CharacterSize.Height * 2));
				}
			}

			this.ResumeLayout();

			base.OnPaint(e);
		}

		protected override void OnPaintBackground(PaintEventArgs e)
		{
			// don't paint the background, we'll take care of it in OnPaint
			//base.OnPaintBackground(e);
		}

		private void MapControl_MouseDown(object sender, MouseEventArgs e)
		{
			TrackSkew = true;
			IsMoving  = false;
			LastPoint = new Point(e.X, e.Y);
		}

		private void MapControl_MouseMove(object sender, MouseEventArgs e)
		{
			if( !TrackSkew )
				return;

			var offset = new Size()
			{
				Width  = Offset.Width  - (e.X - LastPoint.X),
				Height = Offset.Height - (e.Y - LastPoint.Y),
			};

			// if we haven't moved very far from where we started, then
			// don't consider us moving yet
			if( !IsMoving && Math.Abs(LastPoint.X - e.X) < 5 && Math.Abs(LastPoint.Y - e.Y) < 5 )
				return;

			// if we weren't moving but we got here, we are now
			IsMoving = true;

			// make sure we don't scroll off the left side
			if( offset.Width < 0 )
				offset.Width = 0;

			// make sure we don't scroll off the top
			if( offset.Height < 0 )
				offset.Height = 0;

			// make sure we don't scroll off the right side
			if( offset.Width > m_curmap.Width - ClientRectangle.Width )
				offset.Width = m_curmap.Width - ClientRectangle.Width;

			// make sure we don't scroll off the bottom
			if( offset.Height > m_curmap.Height - ClientRectangle.Height )
				offset.Height = m_curmap.Height - ClientRectangle.Height;

			Offset    = offset;
			LastPoint = new Point(e.X, e.Y);

			Invalidate();
		}

		private void MapControl_MouseUp(object sender, MouseEventArgs e)
		{
			// don't track the mouse
			TrackSkew = false;

			// if we got mouse-up but didn't drag, then select whatever
			// is under the mouse
			if( !IsMoving )
			{
				// select the sector
				var sel_x = ((e.X + Offset.Width - (CharacterSize.Width / 2)) / CharacterSize.Width);
				var sel_y = ((e.Y + Offset.Height) / CharacterSize.Height) - 1;

				// if we didn't click a valid sector in the x plane, detect that
				if( (sel_x + 1) % 3 == 0 )
					sel_x = sel_x / 3;
				else
					sel_x = -1;

				// if we selected a valid sector, track that
				if( sel_x < 0 || sel_y < 0 || sel_x > Universe.Sectors.GetUpperBound(0) || sel_y > Universe.Sectors.GetUpperBound(1) )
				{
					SelectedSector = null;
				}
				else
				{
					var new_sel = new Point(sel_x, sel_y);

					if( new_sel == SelectedSector )
						ShowContextMenu(new Point(e.X, e.Y));
					else
						SelectedSector = new_sel;
				}

				Invalidate();
			}
		}

		private void Menu_SendProbe(object sender, EventArgs e)
		{
			// TODO: implement this
		}

		private void ShowContextMenu(Point where)
		{
			ContextMenu.MenuItems.Clear();

			ContextMenu.MenuItems.Add(m_item_probe);
			ContextMenu.MenuItems.Add(m_item_csep);
			ContextMenu.MenuItems.Add(m_item_cancel);

			ContextMenu.Show(this, where);
		}

		private MenuItem CreateMenuItem(string text, EventHandler handler)
		{
			var ret = new MenuItem();

			ret.Text = text;

			if( handler != null )
				ret.Click += handler;

			return ret;
		}

		internal static SectorChar[] GetSectorChars(Universe u, int coord_x, int coord_y, Brushes b)
		{
			var skip_x = 5 - (u.HomeSector.X % 5);
			var skip_y = 5 - (u.HomeSector.Y % 5);
			var ret    = new SectorChar[3];
			var s      = u.Sectors[coord_x, coord_y];

			// first, calculate whatever grid character would be there
			if( (skip_y + coord_y) % 5 == 0 )
			{
				// grid row
				if( (skip_x + coord_x) % 5 == 0 )
				{
					// time for a cross
					ret[0].Character = '─'; ret[0].Brush = b.Gray;
					ret[1].Character = '┼'; ret[1].Brush = b.Gray;
					ret[2].Character = '─'; ret[2].Brush = b.Gray;
				}
				else
				{
					// time for a dot
					ret[1].Character = '·'; ret[1].Brush = b.Gray;
				}
			}
			else
			{
				// normal row
				if( (skip_x + coord_x) % 5 == 0 )
				{
					// time for a dot
					ret[1].Character = '·'; ret[1].Brush = b.Gray;
				}
			}

			// then, calculate nebula
			if( s.Nebula )
			{
				ret[0].Character = '▒'; ret[0].Brush = b.Purple;
				ret[1].Character = '▒'; ret[1].Brush = b.Purple;
				ret[2].Character = '▒'; ret[2].Brush = b.Purple;
			}

			// finally, handle objects
			if( s.Object != null && (s.Probed || !s.Nebula) )
			{
				switch( s.Object.Type )
				{
					case SpaceObjectType.Construction:
						switch( ((Construction)s.Object).ConstructionType )
						{
							case ConstructionType.CommandBase:
								ret[1] = new SectorChar('b', b.Gray);
								break;
							default:
								throw new Exception("Unknown construction type");
						}
						break;

					case SpaceObjectType.World:
						if( !s.Probed )
						{
							ret[1] = new SectorChar('p', b.Red);
							break;
						}

						switch( ((World)s.Object).WorldType )
						{
							default:
								ret[1] = new SectorChar('w', b.Gray);
								break;
						}
						break;

					default:
						throw new Exception("Unknown object type");
				}
			}

			return ret;
		}
	}
}
