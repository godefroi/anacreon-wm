using System;

namespace Anacreon.Engine
{
	public abstract class SpaceObject
	{
		public abstract SpaceObjectType Type { get; }

		public Player Owner { get; set; }
	}
}
