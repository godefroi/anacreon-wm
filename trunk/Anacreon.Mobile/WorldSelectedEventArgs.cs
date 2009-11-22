using System;

using Anacreon.Engine;

namespace Anacreon.Mobile
{
	public class WorldSelectedEventArgs : EventArgs
	{
		public WorldSelectedEventArgs(int x, int y, World world)
		{
			X     = x;
			Y     = y;
			World = world;
		}

		public int X { get; private set; }

		public int Y { get; private set; }

		public World World { get; private set; }
	}
}
