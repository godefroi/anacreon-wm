namespace Anacreon.Mobile
{
	partial class ItemControl
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
			this.LabelLabel = new System.Windows.Forms.Label();
			this.ValueLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// LabelLabel
			// 
			this.LabelLabel.Dock = System.Windows.Forms.DockStyle.Top;
			this.LabelLabel.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Bold);
			this.LabelLabel.ForeColor = System.Drawing.Color.LightGray;
			this.LabelLabel.Location = new System.Drawing.Point(0, 0);
			this.LabelLabel.Name = "LabelLabel";
			this.LabelLabel.Size = new System.Drawing.Size(150, 24);
			this.LabelLabel.Text = "lbl";
			this.LabelLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// ValueLabel
			// 
			this.ValueLabel.BackColor = System.Drawing.Color.DarkBlue;
			this.ValueLabel.Dock = System.Windows.Forms.DockStyle.Top;
			this.ValueLabel.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Bold);
			this.ValueLabel.ForeColor = System.Drawing.Color.LightGray;
			this.ValueLabel.Location = new System.Drawing.Point(0, 24);
			this.ValueLabel.Name = "ValueLabel";
			this.ValueLabel.Size = new System.Drawing.Size(150, 24);
			this.ValueLabel.Text = "val";
			this.ValueLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// ItemControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.Color.DarkBlue;
			this.Controls.Add(this.ValueLabel);
			this.Controls.Add(this.LabelLabel);
			this.Name = "ItemControl";
			this.Size = new System.Drawing.Size(150, 48);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label LabelLabel;
		private System.Windows.Forms.Label ValueLabel;
	}
}
