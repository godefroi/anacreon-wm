namespace Anacreon.Mobile
{
	partial class FleetTransferForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.itemTransferControl14 = new Anacreon.Mobile.ItemTransferControl();
			this.CheItem = new Anacreon.Mobile.ItemTransferControl();
			this.TriItem = new Anacreon.Mobile.ItemTransferControl();
			this.MetItem = new Anacreon.Mobile.ItemTransferControl();
			this.AmbItem = new Anacreon.Mobile.ItemTransferControl();
			this.NnjItem = new Anacreon.Mobile.ItemTransferControl();
			this.MenItem = new Anacreon.Mobile.ItemTransferControl();
			this.StrItem = new Anacreon.Mobile.ItemTransferControl();
			this.HkrItem = new Anacreon.Mobile.ItemTransferControl();
			this.JmpItem = new Anacreon.Mobile.ItemTransferControl();
			this.JtnItem = new Anacreon.Mobile.ItemTransferControl();
			this.PenItem = new Anacreon.Mobile.ItemTransferControl();
			this.TrnItem = new Anacreon.Mobile.ItemTransferControl();
			this.FgtItem = new Anacreon.Mobile.ItemTransferControl();
			this.DescriptionLabel = new System.Windows.Forms.Label();
			this.SmallPlus = new Anacreon.Mobile.SimpleButton();
			this.LargePlus = new Anacreon.Mobile.SimpleButton();
			this.LargeMinus = new Anacreon.Mobile.SimpleButton();
			this.SmallMinus = new Anacreon.Mobile.SimpleButton();
			this.SupItem = new Anacreon.Mobile.ItemTransferControl();
			this.TransferSlider = new System.Windows.Forms.TrackBar();
			this.DialogPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// DialogPanel
			// 
			this.DialogPanel.Controls.Add(this.TransferSlider);
			this.DialogPanel.Controls.Add(this.SupItem);
			this.DialogPanel.Controls.Add(this.LargeMinus);
			this.DialogPanel.Controls.Add(this.SmallMinus);
			this.DialogPanel.Controls.Add(this.LargePlus);
			this.DialogPanel.Controls.Add(this.SmallPlus);
			this.DialogPanel.Controls.Add(this.DescriptionLabel);
			this.DialogPanel.Controls.Add(this.label1);
			this.DialogPanel.Controls.Add(this.itemTransferControl14);
			this.DialogPanel.Controls.Add(this.CheItem);
			this.DialogPanel.Controls.Add(this.TriItem);
			this.DialogPanel.Controls.Add(this.MetItem);
			this.DialogPanel.Controls.Add(this.AmbItem);
			this.DialogPanel.Controls.Add(this.NnjItem);
			this.DialogPanel.Controls.Add(this.MenItem);
			this.DialogPanel.Controls.Add(this.StrItem);
			this.DialogPanel.Controls.Add(this.HkrItem);
			this.DialogPanel.Controls.Add(this.JmpItem);
			this.DialogPanel.Controls.Add(this.JtnItem);
			this.DialogPanel.Controls.Add(this.PenItem);
			this.DialogPanel.Controls.Add(this.TrnItem);
			this.DialogPanel.Controls.Add(this.FgtItem);
			this.DialogPanel.Size = new System.Drawing.Size(448, 716);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.LightGray;
			this.label1.Location = new System.Drawing.Point(8, 336);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(352, 208);
			this.label1.Text = "Transport Capacity:\r\n  5 legions\r\n  5 ninja legions\r\n100 kilotons of ambrosia\r\n  " +
				"3 megatons of chemicals\r\n  3 megatons of metals\r\n  2 megatons of supplies\r\n100 k" +
				"ilotons of trillum\r\n\r\n";
			// 
			// itemTransferControl14
			// 
			this.itemTransferControl14.BottomValue = 9999;
			this.itemTransferControl14.Label = "cargo";
			this.itemTransferControl14.Location = new System.Drawing.Point(360, 336);
			this.itemTransferControl14.Name = "itemTransferControl14";
			this.itemTransferControl14.Selected = false;
			this.itemTransferControl14.Size = new System.Drawing.Size(80, 72);
			this.itemTransferControl14.TabIndex = 28;
			this.itemTransferControl14.TopValue = 9999;
			// 
			// CheItem
			// 
			this.CheItem.BottomValue = 9999;
			this.CheItem.Label = "che";
			this.CheItem.Location = new System.Drawing.Point(104, 248);
			this.CheItem.Name = "CheItem";
			this.CheItem.Selected = false;
			this.CheItem.Size = new System.Drawing.Size(64, 72);
			this.CheItem.TabIndex = 27;
			this.CheItem.TopValue = 9999;
			// 
			// TriItem
			// 
			this.TriItem.BottomValue = 9999;
			this.TriItem.Label = "tri";
			this.TriItem.Location = new System.Drawing.Point(368, 248);
			this.TriItem.Name = "TriItem";
			this.TriItem.Selected = false;
			this.TriItem.Size = new System.Drawing.Size(64, 72);
			this.TriItem.TabIndex = 26;
			this.TriItem.TopValue = 9999;
			// 
			// MetItem
			// 
			this.MetItem.BottomValue = 9999;
			this.MetItem.Label = "met";
			this.MetItem.Location = new System.Drawing.Point(192, 248);
			this.MetItem.Name = "MetItem";
			this.MetItem.Selected = false;
			this.MetItem.Size = new System.Drawing.Size(64, 72);
			this.MetItem.TabIndex = 25;
			this.MetItem.TopValue = 9999;
			// 
			// AmbItem
			// 
			this.AmbItem.BottomValue = 9999;
			this.AmbItem.Label = "amb";
			this.AmbItem.Location = new System.Drawing.Point(16, 248);
			this.AmbItem.Name = "AmbItem";
			this.AmbItem.Selected = false;
			this.AmbItem.Size = new System.Drawing.Size(64, 72);
			this.AmbItem.TabIndex = 24;
			this.AmbItem.TopValue = 9999;
			// 
			// NnjItem
			// 
			this.NnjItem.BottomValue = 9999;
			this.NnjItem.Label = "nnj";
			this.NnjItem.Location = new System.Drawing.Point(368, 160);
			this.NnjItem.Name = "NnjItem";
			this.NnjItem.Selected = false;
			this.NnjItem.Size = new System.Drawing.Size(64, 72);
			this.NnjItem.TabIndex = 23;
			this.NnjItem.TopValue = 9999;
			// 
			// MenItem
			// 
			this.MenItem.BottomValue = 9999;
			this.MenItem.Label = "men";
			this.MenItem.Location = new System.Drawing.Point(280, 160);
			this.MenItem.Name = "MenItem";
			this.MenItem.Selected = false;
			this.MenItem.Size = new System.Drawing.Size(64, 72);
			this.MenItem.TabIndex = 22;
			this.MenItem.TopValue = 9999;
			// 
			// StrItem
			// 
			this.StrItem.BottomValue = 9999;
			this.StrItem.Label = "str";
			this.StrItem.Location = new System.Drawing.Point(104, 160);
			this.StrItem.Name = "StrItem";
			this.StrItem.Selected = false;
			this.StrItem.Size = new System.Drawing.Size(64, 72);
			this.StrItem.TabIndex = 21;
			this.StrItem.TopValue = 9999;
			// 
			// HkrItem
			// 
			this.HkrItem.BottomValue = 9999;
			this.HkrItem.Label = "hkr";
			this.HkrItem.Location = new System.Drawing.Point(136, 72);
			this.HkrItem.Name = "HkrItem";
			this.HkrItem.Selected = false;
			this.HkrItem.Size = new System.Drawing.Size(64, 72);
			this.HkrItem.TabIndex = 20;
			this.HkrItem.TopValue = 9999;
			// 
			// JmpItem
			// 
			this.JmpItem.BottomValue = 9999;
			this.JmpItem.Label = "jmp";
			this.JmpItem.Location = new System.Drawing.Point(248, 72);
			this.JmpItem.Name = "JmpItem";
			this.JmpItem.Selected = false;
			this.JmpItem.Size = new System.Drawing.Size(64, 72);
			this.JmpItem.TabIndex = 19;
			this.JmpItem.TopValue = 9999;
			// 
			// JtnItem
			// 
			this.JtnItem.BottomValue = 9999;
			this.JtnItem.Label = "jtn";
			this.JtnItem.Location = new System.Drawing.Point(360, 72);
			this.JtnItem.Name = "JtnItem";
			this.JtnItem.Selected = false;
			this.JtnItem.Size = new System.Drawing.Size(64, 72);
			this.JtnItem.TabIndex = 18;
			this.JtnItem.TopValue = 9999;
			// 
			// PenItem
			// 
			this.PenItem.BottomValue = 9999;
			this.PenItem.Label = "pen";
			this.PenItem.Location = new System.Drawing.Point(16, 160);
			this.PenItem.Name = "PenItem";
			this.PenItem.Selected = false;
			this.PenItem.Size = new System.Drawing.Size(64, 72);
			this.PenItem.TabIndex = 17;
			this.PenItem.TopValue = 9999;
			// 
			// TrnItem
			// 
			this.TrnItem.BottomValue = 9999;
			this.TrnItem.Label = "trn";
			this.TrnItem.Location = new System.Drawing.Point(192, 160);
			this.TrnItem.Name = "TrnItem";
			this.TrnItem.Selected = false;
			this.TrnItem.Size = new System.Drawing.Size(64, 72);
			this.TrnItem.TabIndex = 16;
			this.TrnItem.TopValue = 9999;
			// 
			// FgtItem
			// 
			this.FgtItem.BottomValue = 9999;
			this.FgtItem.Label = "fgt";
			this.FgtItem.Location = new System.Drawing.Point(24, 72);
			this.FgtItem.Name = "FgtItem";
			this.FgtItem.Selected = false;
			this.FgtItem.Size = new System.Drawing.Size(64, 72);
			this.FgtItem.TabIndex = 14;
			this.FgtItem.TopValue = 9999;
			// 
			// DescriptionLabel
			// 
			this.DescriptionLabel.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Bold);
			this.DescriptionLabel.ForeColor = System.Drawing.Color.LightGray;
			this.DescriptionLabel.Location = new System.Drawing.Point(8, 8);
			this.DescriptionLabel.Name = "DescriptionLabel";
			this.DescriptionLabel.Size = new System.Drawing.Size(432, 48);
			this.DescriptionLabel.Text = "label2\r\nlabel2\r\n";
			// 
			// SmallPlus
			// 
			this.SmallPlus.BackColor = System.Drawing.Color.DarkBlue;
			this.SmallPlus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.SmallPlus.ButtonText = "+";
			this.SmallPlus.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold);
			this.SmallPlus.ForeColor = System.Drawing.Color.LightGray;
			this.SmallPlus.Location = new System.Drawing.Point(232, 648);
			this.SmallPlus.Name = "SmallPlus";
			this.SmallPlus.Size = new System.Drawing.Size(96, 56);
			this.SmallPlus.TabIndex = 29;
			// 
			// LargePlus
			// 
			this.LargePlus.BackColor = System.Drawing.Color.DarkBlue;
			this.LargePlus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.LargePlus.ButtonText = "++";
			this.LargePlus.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold);
			this.LargePlus.ForeColor = System.Drawing.Color.LightGray;
			this.LargePlus.Location = new System.Drawing.Point(344, 648);
			this.LargePlus.Name = "LargePlus";
			this.LargePlus.Size = new System.Drawing.Size(96, 56);
			this.LargePlus.TabIndex = 32;
			// 
			// LargeMinus
			// 
			this.LargeMinus.BackColor = System.Drawing.Color.DarkBlue;
			this.LargeMinus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.LargeMinus.ButtonText = "--";
			this.LargeMinus.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold);
			this.LargeMinus.ForeColor = System.Drawing.Color.LightGray;
			this.LargeMinus.Location = new System.Drawing.Point(8, 648);
			this.LargeMinus.Name = "LargeMinus";
			this.LargeMinus.Size = new System.Drawing.Size(96, 56);
			this.LargeMinus.TabIndex = 34;
			// 
			// SmallMinus
			// 
			this.SmallMinus.BackColor = System.Drawing.Color.DarkBlue;
			this.SmallMinus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.SmallMinus.ButtonText = "-";
			this.SmallMinus.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold);
			this.SmallMinus.ForeColor = System.Drawing.Color.LightGray;
			this.SmallMinus.Location = new System.Drawing.Point(120, 648);
			this.SmallMinus.Name = "SmallMinus";
			this.SmallMinus.Size = new System.Drawing.Size(96, 56);
			this.SmallMinus.TabIndex = 33;
			// 
			// SupItem
			// 
			this.SupItem.BottomValue = 9999;
			this.SupItem.Label = "sup";
			this.SupItem.Location = new System.Drawing.Point(280, 248);
			this.SupItem.Name = "SupItem";
			this.SupItem.Selected = false;
			this.SupItem.Size = new System.Drawing.Size(64, 72);
			this.SupItem.TabIndex = 37;
			this.SupItem.TopValue = 9999;
			// 
			// TransferSlider
			// 
			this.TransferSlider.Location = new System.Drawing.Point(8, 576);
			this.TransferSlider.Maximum = 9999;
			this.TransferSlider.Name = "TransferSlider";
			this.TransferSlider.Size = new System.Drawing.Size(432, 60);
			this.TransferSlider.TabIndex = 40;
			this.TransferSlider.TickFrequency = 0;
			this.TransferSlider.TickStyle = System.Windows.Forms.TickStyle.Both;
			// 
			// FleetTransferForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(480, 748);
			this.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Bold);
			this.ForeColor = System.Drawing.Color.LightGray;
			this.Location = new System.Drawing.Point(0, 52);
			this.MinimizeBox = false;
			this.Name = "FleetTransferForm";
			this.Text = "FleetTransferForm";
			this.DialogPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private ItemTransferControl itemTransferControl14;
		private ItemTransferControl CheItem;
		private ItemTransferControl TriItem;
		private ItemTransferControl MetItem;
		private ItemTransferControl AmbItem;
		private ItemTransferControl NnjItem;
		private ItemTransferControl MenItem;
		private ItemTransferControl StrItem;
		private ItemTransferControl HkrItem;
		private ItemTransferControl JmpItem;
		private ItemTransferControl JtnItem;
		private ItemTransferControl PenItem;
		private ItemTransferControl TrnItem;
		private ItemTransferControl FgtItem;
		private System.Windows.Forms.Label DescriptionLabel;
		private SimpleButton SmallPlus;
		private SimpleButton LargeMinus;
		private SimpleButton SmallMinus;
		private SimpleButton LargePlus;
		private ItemTransferControl SupItem;
		private System.Windows.Forms.TrackBar TransferSlider;

	}
}