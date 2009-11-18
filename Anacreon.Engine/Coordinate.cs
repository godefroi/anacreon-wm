using System;

namespace Anacreon.Engine
{
	public struct Coordinate
	{
		public Coordinate(int x, int y) : this()
		{
			X = x;
			Y = y;
		}

		public int X { get; set; }

		public int Y { get; set; }

	}
}
