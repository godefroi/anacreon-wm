using System;
using System.Drawing;
using System.Windows.Forms;

using Anacreon.Engine;

namespace Anacreon.Mobile
{
	public partial class WorldForm : DialogForm
	{
		public WorldForm(World world)
		{
			InitializeComponent();

			World = world;

			ClassLabel.Text = world.Class;
			TechLabel.Text  = world.Technology;
			PopLabel.Text   = world.Population;
			EffLabel.Text   = string.Format("{0}%", world.Efficiency);
			AmbLabel.Text   = world.Ambrosia ? "yes" : "no";
			RevLabel.Text   = world.Revolution > 0 ? "yes" : "no";
			FlavorText.Text = world.FlavorText;

			AmbItem.Value   = world.Supplies.Ambrosia.ToString();
			CheItem.Value   = world.Supplies.Chemicals.ToString();
			MetItem.Value   = world.Supplies.Metals.ToString();
			SupItem.Value   = world.Supplies.Food.ToString();
			TriItem.Value   = world.Supplies.Trillium.ToString();

			FgtItem.Value   = world.Ships.Fighters.ToString();
			HkrItem.Value   = world.Ships.HunterKillers.ToString();
			JmpItem.Value   = world.Ships.Jumpships.ToString();
			JtnItem.Value   = world.Ships.JumpTransports.ToString();
			PenItem.Value   = world.Ships.Penetrators.ToString();
			StrItem.Value   = world.Ships.Starships.ToString();
			TrnItem.Value   = world.Ships.Transports.ToString();
		}

		protected World World { get; private set; }

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);

			var size = e.Graphics.MeasureString("#", Font);

			//e.Graphics.DrawString("Close Up: star system at 0,0", Font, Brushes.White, size.Width, size.Height);

			/*e.Graphics.DrawString("Cls: Class j",       Font, Brushes.Gray, size.Width * 3, size.Height * 3);
			e.Graphics.DrawString("Tech: bio-tech",     Font, Brushes.Gray, size.Width * 2, size.Height * 4);
			e.Graphics.DrawString("Pop: 36.26 billion", Font, Brushes.Gray, size.Width * 3, size.Height * 5);

			e.Graphics.DrawString("Eff: 75%", Font, Brushes.Gray, size.Width * 23, size.Height * 3);
			e.Graphics.DrawString("Amb: no",  Font, Brushes.Gray, size.Width * 23, size.Height * 4);
			e.Graphics.DrawString("Rev: no",  Font, Brushes.Gray, size.Width * 23, size.Height * 5);*/

			/*var sup_str = string.Format("{0,4} {1,4} {2,4} {3,4} {4,4}", World.Supplies.Ambrosia, World.Supplies.Chemicals, World.Supplies.Metals, World.Supplies.Food, World.Supplies.Trillium);

			if( Screen.PrimaryScreen.Bounds.Width > Screen.PrimaryScreen.Bounds.Height )
			{
				// landscape
				e.Graphics.DrawString("amb  che  met  sup  tri", Font, Brushes.Gray, size.Width * 33, size.Height * 3);
				e.Graphics.DrawString(sup_str,                   Font, Brushes.Gray, size.Width * 32, size.Height * 4);
			}
			else
			{
				// portrait
				e.Graphics.DrawString("amb  che  met  sup  tri", Font, Brushes.Gray, size.Width * 3, size.Height * 7);
				e.Graphics.DrawString(sup_str,                   Font, Brushes.Gray, size.Width * 2, size.Height * 8);
			}*/
		}
	}
}