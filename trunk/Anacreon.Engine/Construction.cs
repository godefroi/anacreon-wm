using System;

namespace Anacreon.Engine
{
	public class Construction : SpaceObject
	{
		public override SpaceObjectType Type
		{
			get { return SpaceObjectType.Construction; }
		}

		public ConstructionType ConstructionType { get; set; }

	}
}
