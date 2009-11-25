namespace Anacreon.Mobile
{
	partial class ItemTransferControl
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if( disposing && (components != null) )
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.TopValueLabel = new System.Windows.Forms.Label();
			this.LabelLabel = new System.Windows.Forms.Label();
			this.BottomValueLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// TopValueLabel
			// 
			this.TopValueLabel.BackColor = System.Drawing.Color.DarkBlue;
			this.TopValueLabel.Dock = System.Windows.Forms.DockStyle.Top;
			this.TopValueLabel.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Bold);
			this.TopValueLabel.ForeColor = System.Drawing.Color.LightGray;
			this.TopValueLabel.Location = new System.Drawing.Point(0, 24);
			this.TopValueLabel.Name = "TopValueLabel";
			this.TopValueLabel.Size = new System.Drawing.Size(65, 24);
			this.TopValueLabel.Text = "9999";
			this.TopValueLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// LabelLabel
			// 
			this.LabelLabel.BackColor = System.Drawing.Color.DarkBlue;
			this.LabelLabel.Dock = System.Windows.Forms.DockStyle.Top;
			this.LabelLabel.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Bold);
			this.LabelLabel.ForeColor = System.Drawing.Color.LightGray;
			this.LabelLabel.Location = new System.Drawing.Point(0, 0);
			this.LabelLabel.Name = "LabelLabel";
			this.LabelLabel.Size = new System.Drawing.Size(65, 24);
			this.LabelLabel.Text = "lbl";
			this.LabelLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// BottomValueLabel
			// 
			this.BottomValueLabel.BackColor = System.Drawing.Color.DarkBlue;
			this.BottomValueLabel.Dock = System.Windows.Forms.DockStyle.Top;
			this.BottomValueLabel.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Bold);
			this.BottomValueLabel.ForeColor = System.Drawing.Color.LightGray;
			this.BottomValueLabel.Location = new System.Drawing.Point(0, 48);
			this.BottomValueLabel.Name = "BottomValueLabel";
			this.BottomValueLabel.Size = new System.Drawing.Size(65, 24);
			this.BottomValueLabel.Text = "9999";
			this.BottomValueLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// ItemTransferControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.Controls.Add(this.BottomValueLabel);
			this.Controls.Add(this.TopValueLabel);
			this.Controls.Add(this.LabelLabel);
			this.Name = "ItemTransferControl";
			this.Size = new System.Drawing.Size(65, 71);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label TopValueLabel;
		private System.Windows.Forms.Label LabelLabel;
		private System.Windows.Forms.Label BottomValueLabel;
	}
}
