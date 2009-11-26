using System;

namespace Anacreon.Engine
{
	public class World : SpaceObject
	{
		public World()
		{
			Fleet    = new Fleet();
			Defenses = new Defenses();

			// TODO: remove this
			Owner = new Player();
		}

		public override SpaceObjectType Type
		{
			get { return SpaceObjectType.World; }
		}

		public Fleet Fleet { get; set; }

		public WorldType WorldType { get; set; }

		public string Class { get; set; }

		public string Technology { get; set; }

		public string Population { get; set; }

		public int Efficiency { get; set; }

		public bool Ambrosia { get; set; }

		public int Revolution { get; set; }

		public Defenses Defenses { get; set; }

		public string FlavorText { get; set; }
	}
}
