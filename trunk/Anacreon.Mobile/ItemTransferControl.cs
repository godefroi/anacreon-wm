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

		public int TopValue
		{
			get { return Convert.ToInt32(TopValueLabel.Text); }
			set { TopValueLabel.Text = value.ToString(); }
		}

		public int BottomValue
		{
			get { return Convert.ToInt32(BottomValueLabel.Text);  }
			set { BottomValueLabel.Text = value.ToString(); }
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
