using System;
using System.Drawing;

namespace Anacreon.Mobile
{
	struct SectorChar
	{
		static SectorChar m_empty = new SectorChar('\0', null);

		public static SectorChar Empty { get { return m_empty; } }

		public SectorChar(char c, Brush b)
		{
			Character = c;
			Brush     = b;
		}

		public char Character;

		public Brush Brush;
	}
}
