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

			AmbItem.Value   = world.Fleet.Ambrosia.ToString();
			CheItem.Value   = world.Fleet.Chemicals.ToString();
			MetItem.Value   = world.Fleet.Metals.ToString();
			SupItem.Value   = world.Fleet.Supplies.ToString();
			TriItem.Value   = world.Fleet.Trillium.ToString();

			FgtItem.Value   = world.Fleet.Fighters.ToString();
			HkrItem.Value   = world.Fleet.HunterKillers.ToString();
			JmpItem.Value   = world.Fleet.Jumpships.ToString();
			JtnItem.Value   = world.Fleet.JumpTransports.ToString();
			PenItem.Value   = world.Fleet.Penetrators.ToString();
			StrItem.Value   = world.Fleet.Starships.ToString();
			TrnItem.Value   = world.Fleet.Transports.ToString();

			MenItem.Value   = world.Fleet.Men.ToString();
			NnjItem.Value   = world.Fleet.Ninjas.ToString();

			LamItem.Value   = world.Defenses.LAM.ToString();
			DefItem.Value   = world.Defenses.DefenseSatellites.ToString();
			GdmItem.Value   = world.Defenses.GDM.ToString();
			IonItem.Value   = world.Defenses.IonCannons.ToString();
		}
	}
}