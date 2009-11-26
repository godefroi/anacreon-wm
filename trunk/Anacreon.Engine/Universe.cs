using System;

namespace Anacreon.Engine
{
	public class Universe
	{
		public Universe(int x, int y)
		{
			Sectors = new SectorCollection(x, y);
		}

		public Coordinate HomeSector { get; set; }

		public SectorCollection Sectors { get; private set; }

		public Player HumanPlayer { get; set; }
	}
}
