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

			MenItem.Value   = world.Troops.Men.ToString();
			NnjItem.Value   = world.Troops.Ninjas.ToString();

			LamItem.Value   = world.Defenses.LAM.ToString();
			DefItem.Value   = world.Defenses.DefenseSatellites.ToString();
			GdmItem.Value   = world.Defenses.GDM.ToString();
			IonItem.Value   = world.Defenses.IonCannons.ToString();
		}
	}
}