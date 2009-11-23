using System;
using System.Drawing;

namespace Anacreon.Mobile
{
	static class Brushes
	{
		static Brushes()
		{
			//Gray   = new SolidBrush(Color.LightGray);
			Gray   = new SolidBrush(Color.FromArgb(192, 192, 192));
			Purple = new SolidBrush(Color.Purple);
			//Red    = new SolidBrush(Color.Red);
			Red    = new SolidBrush(Color.FromArgb(128, 0, 0));
			White  = new SolidBrush(Color.White);
			Black  = new SolidBrush(Color.Black);
		}

		public static Brush Gray { get; private set; }

		public static Brush Purple { get; private set; }

		public static Brush Red { get; private set; }

		public static Brush White { get; private set; }

		public static Brush Black { get; private set; }
	}
}
