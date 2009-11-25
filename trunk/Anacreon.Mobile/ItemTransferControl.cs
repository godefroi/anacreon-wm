using System;
using System.Drawing;
using System.Windows.Forms;

namespace Anacreon.Mobile
{
	public partial class ItemTransferControl : UserControl
	{
		public ItemTransferControl()
		{
			InitializeComponent();
		}

		public string Label
		{
			get { return LabelLabel.Text;  }
			set { LabelLabel.Text = value; }
		}

		public string TopValue
		{
			get { return TopValueLabel.Text;  }
			set { TopValueLabel.Text = value; }
		}

		public string BottomValue
		{
			get { return BottomValueLabel.Text;  }
			set { BottomValueLabel.Text = value; }
		}

		public bool Selected
		{
			get
			{
				return LabelLabel.ForeColor == Color.Black;
			}
			set
			{
				if( value )
				{
					LabelLabel.ForeColor       = Color.Black;
					TopValueLabel.ForeColor    = Color.Black;
					BottomValueLabel.ForeColor = Color.Black;

					LabelLabel.BackColor       = Color.LightGray;
					TopValueLabel.BackColor    = Color.LightGray;
					BottomValueLabel.BackColor = Color.LightGray;
				}
				else
				{
					LabelLabel.ForeColor       = Color.LightGray;
					TopValueLabel.ForeColor    = Color.LightGray;
					BottomValueLabel.ForeColor = Color.LightGray;

					LabelLabel.BackColor       = Color.DarkBlue;
					TopValueLabel.BackColor    = Color.DarkBlue;
					BottomValueLabel.BackColor = Color.DarkBlue;
				}
			}
		}
	}
}
