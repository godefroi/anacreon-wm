using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Anacreon.Engine;

namespace Anacreon.Mobile
{
	public partial class FleetTransferForm : DialogForm
	{
		Fleet               m_top;
		Fleet               m_bottom;
		int                 m_lastval;
		ItemTransferControl m_sel;

		Dictionary<ItemTransferControl, Accessors> m_accessors;

		struct Accessors
		{
			public Func<Fleet, int> Get;
			public Action<Fleet, int> Set;
		}

		public FleetTransferForm(Fleet bottom, Fleet top, string label)
		{
			InitializeComponent();

			m_top       = top;
			m_bottom    = bottom;
			m_accessors = new Dictionary<ItemTransferControl, Accessors>();

			DescriptionLabel.Text = label;

			m_accessors.Add(FgtItem, new Accessors() { Get = f => f.Fighters,       Set = (f, i) => f.Fighters       = i });
			m_accessors.Add(HkrItem, new Accessors() { Get = f => f.HunterKillers,  Set = (f, i) => f.HunterKillers  = i });
			m_accessors.Add(JmpItem, new Accessors() { Get = f => f.Jumpships,      Set = (f, i) => f.Jumpships      = i });
			m_accessors.Add(JtnItem, new Accessors() { Get = f => f.JumpTransports, Set = (f, i) => f.JumpTransports = i });
			m_accessors.Add(PenItem, new Accessors() { Get = f => f.Penetrators,    Set = (f, i) => f.Penetrators    = i });
			m_accessors.Add(StrItem, new Accessors() { Get = f => f.Starships,      Set = (f, i) => f.Starships      = i });
			m_accessors.Add(TrnItem, new Accessors() { Get = f => f.Transports,     Set = (f, i) => f.Transports     = i });
			m_accessors.Add(MenItem, new Accessors() { Get = f => f.Men,            Set = (f, i) => f.Men            = i });
			m_accessors.Add(NnjItem, new Accessors() { Get = f => f.Ninjas,         Set = (f, i) => f.Ninjas         = i });
			m_accessors.Add(AmbItem, new Accessors() { Get = f => f.Ambrosia,       Set = (f, i) => f.Ambrosia       = i });
			m_accessors.Add(CheItem, new Accessors() { Get = f => f.Chemicals,      Set = (f, i) => f.Chemicals      = i });
			m_accessors.Add(MetItem, new Accessors() { Get = f => f.Metals,         Set = (f, i) => f.Metals         = i });
			m_accessors.Add(SupItem, new Accessors() { Get = f => f.Supplies,       Set = (f, i) => f.Supplies       = i });
			m_accessors.Add(TriItem, new Accessors() { Get = f => f.Trillium,       Set = (f, i) => f.Trillium       = i });

			FgtItem.Click += Item_Click;
			HkrItem.Click += Item_Click;
			JmpItem.Click += Item_Click;
			JtnItem.Click += Item_Click;
			PenItem.Click += Item_Click;
			StrItem.Click += Item_Click;
			TrnItem.Click += Item_Click;
			MenItem.Click += Item_Click;
			NnjItem.Click += Item_Click;
			AmbItem.Click += Item_Click;
			CheItem.Click += Item_Click;
			MetItem.Click += Item_Click;
			SupItem.Click += Item_Click;
			TriItem.Click += Item_Click;

			FgtItem.TopValue = top.Fighters;
			HkrItem.TopValue = top.HunterKillers;
			JmpItem.TopValue = top.Jumpships;
			JtnItem.TopValue = top.JumpTransports;
			PenItem.TopValue = top.Penetrators;
			StrItem.TopValue = top.Starships;
			TrnItem.TopValue = top.Transports;
			MenItem.TopValue = top.Men;
			NnjItem.TopValue = top.Ninjas;
			AmbItem.TopValue = top.Ambrosia;
			CheItem.TopValue = top.Chemicals;
			MetItem.TopValue = top.Metals;
			SupItem.TopValue = top.Supplies;
			TriItem.TopValue = top.Chemicals;

			FgtItem.BottomValue = m_bottom.Fighters;
			HkrItem.BottomValue = m_bottom.HunterKillers;
			JmpItem.BottomValue = m_bottom.Jumpships;
			JtnItem.BottomValue = m_bottom.JumpTransports;
			PenItem.BottomValue = m_bottom.Penetrators;
			StrItem.BottomValue = m_bottom.Starships;
			TrnItem.BottomValue = m_bottom.Transports;
			MenItem.BottomValue = m_bottom.Men;
			NnjItem.BottomValue = m_bottom.Ninjas;
			AmbItem.BottomValue = m_bottom.Ambrosia;
			CheItem.BottomValue = m_bottom.Chemicals;
			MetItem.BottomValue = m_bottom.Metals;
			SupItem.BottomValue = m_bottom.Supplies;
			TriItem.BottomValue = m_bottom.Chemicals;

			TransferSlider.ValueChanged += TransferSlider_ValueChanged;
			//LargeMinus.Click            += (s, e) => TransferSlider.Value = Math.Max(TransferSlider.Minimum, TransferSlider.Value - 100);
			LargeMinus.MouseUp          += (s, e) => TransferSlider.Value = Math.Max(TransferSlider.Minimum, TransferSlider.Value - 100);
			//LargeMinus.DoubleClick      += (s, e) => TransferSlider.Value = Math.Max(TransferSlider.Minimum, TransferSlider.Value - 100);
			SmallMinus.Click            += (s, e) => TransferSlider.Value = Math.Max(TransferSlider.Minimum, TransferSlider.Value - 1);
			SmallMinus.DoubleClick      += (s, e) => TransferSlider.Value = Math.Max(TransferSlider.Minimum, TransferSlider.Value - 1);
			SmallPlus.Click             += (s, e) => TransferSlider.Value = Math.Min(TransferSlider.Maximum, TransferSlider.Value + 1);
			SmallPlus.DoubleClick       += (s, e) => TransferSlider.Value = Math.Min(TransferSlider.Maximum, TransferSlider.Value + 1);
			LargePlus.Click             += (s, e) => TransferSlider.Value = Math.Min(TransferSlider.Maximum, TransferSlider.Value + 100);
			LargePlus.DoubleClick       += (s, e) => TransferSlider.Value = Math.Min(TransferSlider.Maximum, TransferSlider.Value + 100);
		}

		private void TransferSlider_ValueChanged(object sender, EventArgs e)
		{
			var diff = TransferSlider.Value - m_lastval;

			if( diff == 0 )
				return;

			// add diff to top, subtract diff from bottom
			m_accessors[m_sel].Set(m_top,    m_accessors[m_sel].Get(m_top)    + diff);
			m_accessors[m_sel].Set(m_bottom, m_accessors[m_sel].Get(m_bottom) - diff);

			// now, reset the labels to match the new values
			m_sel.TopValue    = m_accessors[m_sel].Get(m_top);
			m_sel.BottomValue = m_accessors[m_sel].Get(m_bottom);

			m_lastval = TransferSlider.Value;
		}

		private void Item_Click(object sender, EventArgs e)
		{
			var sel_item = sender as ItemTransferControl;

			FgtItem.Selected = false;
			HkrItem.Selected = false;
			JmpItem.Selected = false;
			JtnItem.Selected = false;
			PenItem.Selected = false;
			StrItem.Selected = false;
			TrnItem.Selected = false;
			MenItem.Selected = false;
			NnjItem.Selected = false;
			AmbItem.Selected = false;
			CheItem.Selected = false;
			MetItem.Selected = false;
			TriItem.Selected = false;

			sel_item.Selected = true;

			var top_val = m_accessors[sel_item].Get(m_top);
			var bot_val = m_accessors[sel_item].Get(m_bottom);

			m_sel     = sel_item;
			m_lastval = 0;

			//TransferSlider.Minimum = Math.Max(-9999, -(top_val + bot_val));  // right?
			//TransferSlider.Maximum = Math.Min(9999, top_val + bot_val);      // not right?

			TransferSlider.Minimum = Math.Max(-9999, -top_val);
			TransferSlider.Maximum = Math.Min(9999 - top_val, bot_val); 

			TransferSlider.Value   = m_lastval;
		}
	}
}