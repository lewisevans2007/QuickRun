using System;
using System.Windows.Forms;
using System.Reflection;
namespace QuickRun
{
	public partial class MainWindow : Form
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Version.Text = Assembly.GetEntryAssembly().GetName().Version.ToString();
			Trayicon.BalloonTipIcon = ToolTipIcon.Info;
			Trayicon.BalloonTipText = "Welome to quick run";
			Trayicon.BalloonTipTitle = "QuickRun " + Assembly.GetEntryAssembly().GetName().Version;
			Trayicon.ShowBalloonTip(500);
			TopMost = true;
		}

		private void Exit_onclick(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void Run_onclick(object sender, EventArgs e)
		{
			string strCmdText;
			strCmdText = Args.Text;
			if (strCmdText == "Enter Arguments")
			{
				strCmdText = "";
			}
			try
			{
				//Try create a minimized window, with the Command and Argument text.
				System.Diagnostics.Process.Start(Command.Text, strCmdText);
				WindowState = FormWindowState.Minimized;
				Command.Text = "Enter Command";
				Args.Text = "Enter Arguments (Optional)";
				Hide();
				//Create a notification to notify the user that QuickRun is running in the background as the system tray.
				Trayicon.BalloonTipIcon = ToolTipIcon.Info;
				Trayicon.BalloonTipText = "To open it click on the system tray icon (it could be hidden in the arrow).";
				Trayicon.BalloonTipTitle = "QuickRun is running in the background";
				Trayicon.ShowBalloonTip(500);
			}
			catch (Exception)
			{
				Error f3 = new Error();
				f3.ShowDialog();
			}

		}
		private void CheckEnterKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Return)

			{

				string strCmdText;
				strCmdText = Args.Text;
				if (strCmdText == "Enter Arguments (Optional)")
				{
					strCmdText = "";
				}
				try
				{
					//Try create a minimized window, with the Command and Argument text.
					System.Diagnostics.Process.Start(Command.Text, strCmdText);
					WindowState = FormWindowState.Minimized;
					Command.Text = "Enter Command";
					Args.Text = "Enter Arguments (Optional)";
					Hide();
					//Create a notification to notify the user that QuickRun is running in the background as the system tray.
					Trayicon.BalloonTipIcon = ToolTipIcon.Info;
					Trayicon.BalloonTipText = "To open it click on the system tray icon (it could be hidden in the arrow).";
					Trayicon.BalloonTipTitle = "QuickRun is running in the background";
					Trayicon.ShowBalloonTip(500);
				}
				catch (Exception)
				{
					Error f3 = new Error();
					f3.ShowDialog();
				}
				WindowState = FormWindowState.Minimized;
				Hide();
			}
		}

		private void TrayIcon_MouseClick(object sender, MouseEventArgs e)
		{
			Show();
			WindowState = FormWindowState.Normal;
		}

		private void HideButton_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
			this.Hide();
		}

		private void cmd_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("cmd", "");
		}
		private void explorer_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("explorer", "");
		}

		private void about_Click(object sender, EventArgs e)
		{
			Info info = new Info();
			info.ShowDialog();
		}

		private void Form_close(object sender, FormClosedEventArgs e)
		{
			const string message =
			"Doing this will close the form. You can use hide instead if you don't want to reopen this again";
			const string caption = "QuickRun";
			var result = MessageBox.Show(message, caption,
										 MessageBoxButtons.OK,
										 MessageBoxIcon.Asterisk);
		}
	}
}
