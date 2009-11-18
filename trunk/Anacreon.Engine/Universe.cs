using System;

namespace Anacreon.Engine
{
	public class Universe
	{
		public Universe(int x, int y)
		{
			Sectors = new Sector[x, y];

			for( var xc = 0; xc < x; xc++ )
			{
				for( var yc = 0; yc < y; yc++ )
					Sectors[xc, yc] = new Sector();
			}
		}

		public Coordinate HomeSector { get; set; }

		public Sector[,] Sectors { get; private set; }

	}
}
