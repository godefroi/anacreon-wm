using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Anacreon.Mobile
{
	public partial class DialogForm : Form
	{
		public DialogForm()
		{
			InitializeComponent();
		}

		protected override void OnPaintBackground(PaintEventArgs e)
		{
			base.OnPaintBackground(e);

			var line_w = 3;
			var l_x    = 7;
			var r_x    = ClientRectangle.Width - 10;
			var t_y    = 7;
			var b_y    = ClientRectangle.Height - 10;
			var v_h    = b_y - t_y;
			var h_w    = r_x - l_x + line_w;

			// left line
			e.Graphics.FillRectangle(Brushes.Gray, l_x, t_y, line_w, v_h);

			// right line
			e.Graphics.FillRectangle(Brushes.Gray, r_x, t_y, line_w, v_h);

			// bottom line
			e.Graphics.FillRectangle(Brushes.Gray, l_x, b_y, h_w, line_w);
		}

		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);

			DialogPanel.Top    = 16;
			DialogPanel.Left   = 16;
			DialogPanel.Width  = ClientRectangle.Width - 32;
			DialogPanel.Height = ClientRectangle.Height - 32;
		}
	}
}