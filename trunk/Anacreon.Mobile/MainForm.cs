using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

using Anacreon.Engine;

namespace Anacreon.Mobile
{
	public partial class MainForm : Form
	{
		[DllImport("AYGShell.dll")]
		static extern Int32 SHFullScreen(IntPtr hwndRequester, UInt32 dwState);

		const uint SHFS_SHOWTASKBAR = 0x0001;
		const uint SHFS_HIDETASKBAR = 0x0002;
		const uint SHFS_SHOWSIPBUTTON = 0x0004;
		const uint SHFS_HIDESIPBUTTON = 0x0008;
		const uint SHFS_SHOWSTARTICON = 0x0010;
		const uint SHFS_HIDESTARTICON = 0x0020;

		public MainForm()
		{
			InitializeComponent();

			Activated += (s, e) => SHFullScreen(Handle, SHFS_HIDESIPBUTTON);

			var mc = new MapControl(Program.CreateUniverse());

			Controls.Add(mc);

			mc.Dock = DockStyle.Fill;

			mc.WorldSelected += (s, e) =>
				{
					using( var wf = new WorldForm(e.World) )
						wf.ShowDialog();
				};
		}

		private void MainForm_KeyDown(object sender, KeyEventArgs e)
		{
			if( e.KeyCode == System.Windows.Forms.Keys.Up )
			{
				// Up
			}
			if( e.KeyCode == System.Windows.Forms.Keys.Down )
			{
				Application.Exit();
			}
			if( e.KeyCode == System.Windows.Forms.Keys.Left )
			{
				// Left
			}
			if( e.KeyCode == System.Windows.Forms.Keys.Right )
			{
				// Right
			}
			if( e.KeyCode == System.Windows.Forms.Keys.Enter )
			{
				// Enter
			}
		}

		private void MainForm_Resize(object sender, EventArgs e)
		{
			//Microsoft.WindowsCE.Forms.SystemSettings.ScreenOrientation == Microsoft.WindowsCE.Forms.ScreenOrientation.
			//SystemInformation.
			//this.Refresh();

		}
	}
}