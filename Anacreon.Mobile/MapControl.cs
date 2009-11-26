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
		MenuItem  m_item_selworld;
		MenuItem  m_item_depfleet;
		MenuItem  m_item_probe;
		MenuItem  m_item_csep;
		MenuItem  m_item_tsep;
		MenuItem  m_item_cancel;
		Image     m_off_img;
		Graphics  m_off_g;
		Size      m_mapsize;

		public MapControl(Universe universe)
		{
			Universe    = universe;
			LastPoint   = Point.Empty;
			Offset      = Size.Empty;
			ContextMenu = new ContextMenu();

			//DoubleClick += (s, e) => { throw new Exception("double click"); };

			InitializeComponent();

			using( var g = CreateGraphics() )
			{
				var cs = g.MeasureString("#", Font);
				CharacterSize = new Size(Convert.ToInt32(cs.Width), Convert.ToInt32(cs.Height));
			}

			Disposed += Form_Disposed;
			Resize   += Form_Resize;

			ContextMenu.Popup += ContextMenu_Popup;

			m_mapsize = new Size(((Universe.Sectors.GetLength(0) * 3) + 2) * CharacterSize.Width, (Universe.Sectors.GetLength(1) + 2) * CharacterSize.Height);

			m_item_selworld = CreateMenuItem("Select World", Menu_SelectWorld);
			m_item_depfleet = CreateMenuItem("Deploy Fleet", Menu_DeployFleet);
			m_item_probe    = CreateMenuItem("Send Probe",   Menu_SendProbe);
			m_item_tsep     = CreateMenuItem("-",            null);
			m_item_csep     = CreateMenuItem("-",            null);
			m_item_cancel   = CreateMenuItem("Cancel",       null);
		}

		public event EventHandler<WorldSelectedEventArgs> WorldSelected;

		protected Universe Universe { get; private set; }

		protected Size CharacterSize { get; private set; }

		private Point LastPoint { get; set; }

		private Size Offset { get; set; }

		protected Point? SelectedSector { get; set; }

		private bool TrackSkew { get; set; }

		private bool IsMoving { get; set; }

		private int DrawX { get; set; }

		private int DrawY { get; set; }

		protected virtual void OnWorldSelected(WorldSelectedEventArgs e)
		{
			if( WorldSelected != null )
				WorldSelected(this, e);
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			var sect_x = Offset.Width / (CharacterSize.Width * 3);
			var off_x  = (sect_x * CharacterSize.Width * 3) - Offset.Width + CharacterSize.Width;

			var sect_y = Offset.Height / CharacterSize.Height;
			var off_y  = (sect_y * CharacterSize.Height) - Offset.Height;

			var dcnt = 0;
			var sw   = System.Diagnostics.Stopwatch.StartNew();

			m_off_g.Clear(Color.Black);

			var swb = new System.Diagnostics.Stopwatch();
			var sws = new System.Diagnostics.Stopwatch();

			for( var y = 0; y <= DrawY && y + sect_y <= Universe.Sectors.GetUpperBound(1); y++ )
			{
				var y_pos = (y * CharacterSize.Height) + off_y + CharacterSize.Height;
				var sects = new List<SectorChar[]>();

				for( var x = 0; x <= DrawX && x + sect_x <= Universe.Sectors.GetUpperBound(0); x++ )
					sects.Add(GetSectorChars(Universe, x + sect_x, y + sect_y));

				var chars = sects.SelectMany(a => a).ToArray();

				foreach( var b in chars.Where(c => c.Brush != null).Select(c => c.Brush).Distinct() )
				{
					sws.Start();
					var s = new string(chars.Select(c => c.Brush == b && c.Character != '\0' ? c.Character : ' ').ToArray());
					sws.Stop();

					dcnt++;
					m_off_g.DrawString(s, Font, b, off_x, y_pos);
				}
			}

			e.Graphics.DrawImage(m_off_img, 0, 0);

			if( SelectedSector != null )
			{
				var coord_x = (((SelectedSector.Value.X * 3) + 1) * CharacterSize.Width) - Offset.Width;
				var coord_y = ((SelectedSector.Value.Y) * CharacterSize.Height) - Offset.Height;

				e.Graphics.DrawString("┌ ┐", Font, Brushes.White, coord_x, coord_y);
				e.Graphics.DrawString("└ ┘", Font, Brushes.White, coord_x, coord_y + (CharacterSize.Height * 2));
			}

			sw.Stop();

			/*using( var brush = new SolidBrush(Color.Blue) )
			using( var font = new Font(Font.Name, Font.Size + 2, FontStyle.Bold) )
			{
				e.Graphics.DrawString(string.Format("char: {0}x{1}", CharacterSize.Width, CharacterSize.Height), font, brush, 0, 100);
				e.Graphics.DrawString(string.Format("clirect: {0}x{1}", ClientRectangle.Width, ClientRectangle.Height), font, brush, 0, 120);
				e.Graphics.DrawString(string.Format("map: {0}x{1}", m_mapsize.Width, m_mapsize.Height), font, brush, 0, 140);
				e.Graphics.DrawString(string.Format("time: {0} {1}", sw.ElapsedMilliseconds, sws.ElapsedMilliseconds), font, brush, 0, 160);
				e.Graphics.DrawString(string.Format("offset: h {0} v {1}", Offset.Width, Offset.Height), font, brush, 0, 180);
				e.Graphics.DrawString(string.Format("last point: {0}, {1}", LastPoint.X, LastPoint.Y), font, brush, 0, 200);
				e.Graphics.DrawString(string.Format("dcnt: {0}", dcnt), font, brush, 0, 220);

				if( SelectedSector != null )
				{
					var coord_x = (((SelectedSector.Value.X * 3) + 1) * CharacterSize.Width) - Offset.Width;
					var coord_y = ((SelectedSector.Value.Y) * CharacterSize.Height) - Offset.Height;

					e.Graphics.DrawString(string.Format("sel sect: {0}, {1}", SelectedSector.Value.X, SelectedSector.Value.Y), font, brush, 0, 240);
					e.Graphics.DrawString(string.Format("sel coord: {0}, {1}", coord_x, coord_y), font, brush, 0, 260);
				}
			}*/

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
			if( offset.Width > m_mapsize.Width - ClientRectangle.Width )
				offset.Width = m_mapsize.Width - ClientRectangle.Width;

			// make sure we don't scroll off the bottom
			if( offset.Height > m_mapsize.Height - ClientRectangle.Height )
				offset.Height = m_mapsize.Height - ClientRectangle.Height;

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
				var sel_pt = GetSectorAtPoint(e.X, e.Y);

				if( sel_pt == null )
					SelectedSector = null;
				else if( sel_pt == SelectedSector )
					ContextMenu.Show(this, new Point(e.X, e.Y));
				else
					SelectedSector = sel_pt;

				Invalidate();
			}
		}

		private void Menu_SendProbe(object sender, EventArgs e)
		{
			// TODO: implement this
		}

		private void Menu_SelectWorld(object sender, EventArgs e)
		{
			if( !SelectedSector.HasValue )
				return;

			var x = SelectedSector.Value.X;
			var y = SelectedSector.Value.Y;
			var w = Universe.Sectors[x,y].Object as World;

			if( w == null )
				return;

			OnWorldSelected(new WorldSelectedEventArgs(x, y, w));
		}
		
		private void Menu_DeployFleet(object sender, EventArgs e)
		{
			var world = Universe.Sectors[SelectedSector.Value.X, SelectedSector.Value.Y].Object as World;
			var fleet = new Fleet();

			using( var tf = new FleetTransferForm(world.Fleet, fleet, string.Format("Ready to deploy a new fleet from the world at {0}", SelectedSector)) )
			{
				tf.ShowDialog();
			}

			Universe.Sectors[SelectedSector.Value.X, SelectedSector.Value.Y].Fleets.Add(fleet);

			Invalidate();
		}

		private void ContextMenu_Popup(object sender, EventArgs e)
		{
			ContextMenu.MenuItems.Clear();

			if( SelectedSector != null )
			{
				var s = Universe.Sectors[SelectedSector.Value.X, SelectedSector.Value.Y];

				if( s.Object != null && s.Object.Type == SpaceObjectType.World )
				{
					ContextMenu.MenuItems.Add(m_item_selworld);

					if( s.Object.Owner == Universe.HumanPlayer )
						ContextMenu.MenuItems.Add(m_item_depfleet);

					ContextMenu.MenuItems.Add(m_item_tsep);
				}
			}

			ContextMenu.MenuItems.Add(m_item_probe);
			ContextMenu.MenuItems.Add(m_item_csep);
			ContextMenu.MenuItems.Add(m_item_cancel);
		}

		private void Form_Disposed(object sender, EventArgs e)
		{
			if( m_off_img != null )
				m_off_img.Dispose();

			if( m_off_g != null )
				m_off_g.Dispose();
		}

		private void Form_Resize(object sender, EventArgs e)
		{
			if( m_off_img != null )
				m_off_img.Dispose();

			if( m_off_g != null )
				m_off_g.Dispose();

			m_off_img    = new Bitmap(ClientRectangle.Width, ClientRectangle.Height);
			m_off_g      = Graphics.FromImage(m_off_img);
			m_off_g.Clip = new Region(new Rectangle(CharacterSize.Width, CharacterSize.Height, ClientRectangle.Width - (CharacterSize.Width * 2), ClientRectangle.Height - (CharacterSize.Height * 2)));

			DrawX = (int)Math.Ceiling(m_off_g.ClipBounds.Width / ((float)CharacterSize.Width * 3f));
			DrawY = (int)Math.Ceiling(m_off_g.ClipBounds.Height / (float)CharacterSize.Height);
		}

		private void ShowContextMenu(Point where, Sector s)
		{

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

		private Point? GetSectorAtPoint(int x, int y)
		{
			// select the sector
			var sel_x = ((x + Offset.Width) / CharacterSize.Width);
			var sel_y = ((y + Offset.Height) / CharacterSize.Height) - 1;

			// if we didn't click a valid sector in the x plane, detect that
			if( (sel_x + 1) % 3 == 0 )
				sel_x = sel_x / 3;
			else
				sel_x = -1;

			// if we selected a valid sector, track that
			if( sel_x < 0 || sel_y < 0 || sel_x > Universe.Sectors.GetUpperBound(0) || sel_y > Universe.Sectors.GetUpperBound(1) )
				return null;
			else
				return new Point(sel_x, sel_y);
		}

		internal static SectorChar[] GetSectorChars(Universe u, int coord_x, int coord_y)
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
					ret[0].Character = '─'; ret[0].Brush = Brushes.Gray;
					ret[1].Character = '┼'; ret[1].Brush = Brushes.Gray;
					ret[2].Character = '─'; ret[2].Brush = Brushes.Gray;
				}
				else
				{
					// time for a dot
					ret[1].Character = '·'; ret[1].Brush = Brushes.Gray;
				}
			}
			else
			{
				// normal row
				if( (skip_x + coord_x) % 5 == 0 )
				{
					// time for a dot
					ret[1].Character = '·'; ret[1].Brush = Brushes.Gray;
				}
			}

			// then, calculate nebula
			if( s.Nebula )
			{
				ret[0].Character = '▒'; ret[0].Brush = Brushes.Purple;
				ret[1].Character = '▒'; ret[1].Brush = Brushes.Purple;
				ret[2].Character = '▒'; ret[2].Brush = Brushes.Purple;
			}

			// handle fleets
			if( s.Fleets.Any(f => f.Owner == u.HumanPlayer) )
			{
				// at least one friendly fleet
				ret[0].Character = '►';
				ret[0].Brush     = Brushes.White;
			}

			if( s.Fleets.Any(f => f.Owner != u.HumanPlayer) )
			{
				// at least one unfriendly fleet
				ret[2].Character = '◄';
				ret[2].Brush     = Brushes.Gray;
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
								ret[1] = new SectorChar('b', Brushes.Gray);
								break;
							default:
								throw new Exception("Unknown construction type");
						}
						break;

					case SpaceObjectType.World:
						if( !s.Probed )
						{
							ret[1] = new SectorChar('p', Brushes.Red);
							break;
						}

						var w = (World)s.Object;
						var b = Brushes.Gray;

						if( w.Owner == u.HumanPlayer )
							b = Brushes.White;

						switch( w.WorldType )
						{
							case WorldType.Capitol:
								ret[1] = new SectorChar('C', b);
								break;

							default:
								ret[1] = new SectorChar('w', b);
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
