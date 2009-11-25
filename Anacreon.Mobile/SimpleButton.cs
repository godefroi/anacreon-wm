using System;
using System.Windows.Forms;
using System.Drawing;

namespace Anacreon.Mobile
{
	public partial class SimpleButton : UserControl
	{
		public SimpleButton()
		{
			InitializeComponent();
		}

		public override Color ForeColor
		{
			get
			{
				return base.ForeColor;
			}
			set
			{
				base.ForeColor = value;
			}
		}

		public override Color BackColor
		{
			get
			{
				return base.BackColor;
			}
			set
			{
				base.BackColor = value;
			}
		}

		public string ButtonText { get; set; }

		protected override void OnPaint(PaintEventArgs e)
		{
			//base.OnPaint(e);

			var text_size = e.Graphics.MeasureString(ButtonText, Font);
			var x_offset  = ((float)Size.Width - text_size.Width) / 2f;
			var y_offset  = ((float)Size.Height - text_size.Height) / 2f;

			e.Graphics.DrawString(ButtonText, Font, Brushes.Gray, x_offset, y_offset);
		}


	}
}
