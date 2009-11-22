namespace Anacreon.Mobile
{
	partial class MapControl
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
			this.SuspendLayout();
			// 
			// MapControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.Color.Black;
			this.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold);
			this.ForeColor = System.Drawing.Color.White;
			this.Name = "MapControl";
			this.Size = new System.Drawing.Size(240, 400);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MapControl_MouseMove);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MapControl_MouseDown);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MapControl_MouseUp);
			this.ResumeLayout(false);

		}

		#endregion


	}
}
