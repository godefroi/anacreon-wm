using System;
using System.Collections.Generic;

namespace Anacreon.Engine
{
	public class Sector
	{
		public Sector()
		{
			Probed = false;
			Fleets = new List<Fleet>();
		}

		public bool Nebula { get; set; }

		public bool Probed { get; set; }

		public SpaceObject Object { get; set; }

		public List<Fleet> Fleets { get; private set; }
	}
}
