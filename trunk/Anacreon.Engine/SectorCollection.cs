using System;
using System.Drawing;

namespace Anacreon.Engine
{
	public class SectorCollection
	{
		Sector[,] m_sectors;

		public SectorCollection(int x, int y)
		{
			m_sectors = new Sector[x, y];

			for( var xc = 0; xc < x; xc++ )
			{
				for( var yc = 0; yc < y; yc++ )
					m_sectors[xc, yc] = new Sector();
			}
		}

		public Sector this[Point? point]
		{
			get
			{
				if( !point.HasValue )
					return null;

				return m_sectors[point.Value.X, point.Value.Y];
			}
			set
			{
				if( !point.HasValue )
					throw new ArgumentException("Invalid value for point", "point");

				m_sectors[point.Value.X, point.Value.Y] = value;
			}
		}

		public Sector this[Point point]
		{
			get
			{
				return m_sectors[point.X, point.Y];
			}
			set
			{
				m_sectors[point.X, point.Y] = value;
			}
		}

		public Sector this[int X, int Y]
		{
			get
			{
				return m_sectors[X, Y];
			}
			set
			{
				m_sectors[X, Y] = value;
			}
		}

		public int LowerBoundX
		{
			get { return m_sectors.GetLowerBound(0); }
		}

		public int UpperBoundX
		{
			get { return m_sectors.GetUpperBound(0); }
		}

		public int LowerBoundY
		{
			get { return m_sectors.GetLowerBound(1); }
		}

		public int UpperBoundY
		{
			get { return m_sectors.GetUpperBound(1); }
		}
	}
}
