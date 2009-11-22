namespace Anacreon.Mobile
{
	partial class DialogForm
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.DialogPanel = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// DialogPanel
			// 
			this.DialogPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.DialogPanel.BackColor = System.Drawing.Color.DarkBlue;
			this.DialogPanel.Location = new System.Drawing.Point(16, 16);
			this.DialogPanel.Name = "DialogPanel";
			this.DialogPanel.Size = new System.Drawing.Size(448, 716);
			// 
			// DialogForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(480, 748);
			this.Controls.Add(this.DialogPanel);
			this.Location = new System.Drawing.Point(0, 52);
			this.Name = "DialogForm";
			this.Text = "DialogForm";
			this.ResumeLayout(false);

		}

		#endregion

		protected System.Windows.Forms.Panel DialogPanel;

	}
}