using System;
using System.Collections.Generic;

namespace Anacreon.Engine
{
	public class PlayerState
	{
		List<Coordinate> m_pendingprobes;

		public bool LaunchProbe(int x, int y)
		{
			if( m_pendingprobes.Count >= 10 )
				return false;

			m_pendingprobes.Add(new Coordinate(x, y));

			return true;
		}
	}
}
