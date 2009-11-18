using System;
using System.Drawing;

namespace Anacreon.Mobile
{
	class Brushes : IDisposable
	{
		public Brushes()
		{
			Gray   = new SolidBrush(Color.Gray);
			Purple = new SolidBrush(Color.Purple);
			Red    = new SolidBrush(Color.Red);
			White  = new SolidBrush(Color.White);
		}

		public void Dispose()
		{
			Gray.Dispose();
			Purple.Dispose();
			Red.Dispose();
			White.Dispose();
		}

		public Brush Gray { get; private set; }

		public Brush Purple { get; private set; }

		public Brush Red { get; private set; }

		public Brush White { get; private set; }
	}
}
