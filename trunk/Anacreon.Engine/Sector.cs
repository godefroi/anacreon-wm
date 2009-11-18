using System;

namespace Anacreon.Engine
{
	public class Sector
	{
		public Sector()
		{
			Probed = false;
		}

		public bool Nebula { get; set; }

		public bool Probed { get; set; }

		public SpaceObject Object { get; set; }
	}
}
