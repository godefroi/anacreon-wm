using System;
using System.Windows.Forms;

namespace Anacreon.Mobile
{
	public partial class ItemControl : UserControl
	{
		public ItemControl()
		{
			InitializeComponent();
		}

		public string Label
		{
			get { return LabelLabel.Text;  }
			set { LabelLabel.Text = value; }
		}

		public string Value
		{
			get { return ValueLabel.Text;  }
			set { ValueLabel.Text = value; }
		}

		/*public override System.Drawing.Font Font
		{
			get
			{
				return base.Font;
			}
			set
			{
				base.Font       = value;
				LabelLabel.Font = value;
				ValueLabel.Font = value;
			}
		}

		public override System.Drawing.Color BackColor
		{
			get
			{
				return base.BackColor;
			}
			set
			{
				base.BackColor       = value;
				LabelLabel.BackColor = value;
				ValueLabel.BackColor = value;
			}
		}

		public override System.Drawing.Color ForeColor
		{
			get
			{
				return base.ForeColor;
			}
			set
			{
				base.ForeColor       = value;
				LabelLabel.ForeColor = value;
				ValueLabel.ForeColor = value;
			}
		}*/
	}
}
