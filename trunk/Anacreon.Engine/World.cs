using System;

namespace Anacreon.Engine
{
	public class World : SpaceObject
	{
		public override SpaceObjectType Type
		{
			get { return SpaceObjectType.World; }
		}

		public WorldType WorldType { get; set; }

	}
}
