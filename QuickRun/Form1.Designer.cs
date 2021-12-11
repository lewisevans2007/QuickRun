namespace QuickRun
{
	partial class MainWindow
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
			if (disposing && (components != null))
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
			this.Exit = new System.Windows.Forms.Button();
			this.Command = new System.Windows.Forms.TextBox();
			this.Args = new System.Windows.Forms.TextBox();
			this.Title = new System.Windows.Forms.Label();
			this.Run = new System.Windows.Forms.Button();
			this.Trayicon = new System.Windows.Forms.NotifyIcon(this.components);
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.HideButton = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.Version = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// Exit
			// 
			this.Exit.BackColor = System.Drawing.Color.Red;
			this.Exit.ForeColor = System.Drawing.Color.White;
			this.Exit.Location = new System.Drawing.Point(269, 77);
			this.Exit.Margin = new System.Windows.Forms.Padding(2);
			this.Exit.Name = "Exit";
			this.Exit.Size = new System.Drawing.Size(37, 20);
			this.Exit.TabIndex = 0;
			this.Exit.Text = "Quit";
			this.Exit.UseVisualStyleBackColor = false;
			this.Exit.Click += new System.EventHandler(this.Exit_onclick);
			// 
			// Command
			// 
			this.Command.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.Command.ForeColor = System.Drawing.Color.White;
			this.Command.Location = new System.Drawing.Point(9, 54);
			this.Command.Margin = new System.Windows.Forms.Padding(2);
			this.Command.Name = "Command";
			this.Command.Size = new System.Drawing.Size(106, 20);
			this.Command.TabIndex = 1;
			this.Command.Text = "Enter Command";
			this.Command.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckEnterKeyPress);
			// 
			// Args
			// 
			this.Args.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.Args.ForeColor = System.Drawing.Color.White;
			this.Args.Location = new System.Drawing.Point(118, 54);
			this.Args.Margin = new System.Windows.Forms.Padding(2);
			this.Args.Name = "Args";
			this.Args.Size = new System.Drawing.Size(188, 20);
			this.Args.TabIndex = 2;
			this.Args.Text = "Enter Arguments (Optional)";
			// 
			// Title
			// 
			this.Title.AutoSize = true;
			this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Title.ForeColor = System.Drawing.Color.DodgerBlue;
			this.Title.Location = new System.Drawing.Point(76, 9);
			this.Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Title.Name = "Title";
			this.Title.Size = new System.Drawing.Size(230, 26);
			this.Title.TabIndex = 3;
			this.Title.Text = "Welcome to QuickRun";
			// 
			// Run
			// 
			this.Run.BackColor = System.Drawing.Color.Lime;
			this.Run.Location = new System.Drawing.Point(183, 78);
			this.Run.Margin = new System.Windows.Forms.Padding(2);
			this.Run.Name = "Run";
			this.Run.Size = new System.Drawing.Size(40, 19);
			this.Run.TabIndex = 4;
			this.Run.Text = "Run";
			this.Run.UseVisualStyleBackColor = false;
			this.Run.Click += new System.EventHandler(this.Run_onclick);
			// 
			// Trayicon
			// 
			this.Trayicon.Icon = ((System.Drawing.Icon)(resources.GetObject("Trayicon.Icon")));
			this.Trayicon.Text = "Click to open quick run";
			this.Trayicon.Visible = true;
			this.Trayicon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TrayIcon_MouseDoubleClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(11, 8);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(44, 42);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			// 
			// HideButton
			// 
			this.HideButton.BackColor = System.Drawing.Color.Yellow;
			this.HideButton.Location = new System.Drawing.Point(227, 78);
			this.HideButton.Margin = new System.Windows.Forms.Padding(2);
			this.HideButton.Name = "HideButton";
			this.HideButton.Size = new System.Drawing.Size(38, 19);
			this.HideButton.TabIndex = 6;
			this.HideButton.Text = "Hide";
			this.HideButton.UseVisualStyleBackColor = false;
			this.HideButton.Click += new System.EventHandler(this.HideButton_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Lime;
			this.button1.Location = new System.Drawing.Point(9, 78);
			this.button1.Margin = new System.Windows.Forms.Padding(2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(60, 19);
			this.button1.TabIndex = 7;
			this.button1.Text = "Cmd";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.cmd_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Lime;
			this.button2.Location = new System.Drawing.Point(73, 77);
			this.button2.Margin = new System.Windows.Forms.Padding(2);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(60, 19);
			this.button2.TabIndex = 8;
			this.button2.Text = "Explorer";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.explorer_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(80, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(129, 13);
			this.label1.TabIndex = 9;
			this.label1.Text = "The improved run window";
			// 
			// Version
			// 
			this.Version.AutoSize = true;
			this.Version.ForeColor = System.Drawing.Color.Gray;
			this.Version.Location = new System.Drawing.Point(265, 35);
			this.Version.Name = "Version";
			this.Version.Size = new System.Drawing.Size(40, 13);
			this.Version.TabIndex = 10;
			this.Version.Text = "0.0.0.0";
			this.Version.Click += new System.EventHandler(this.Version_Click);
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.ClientSize = new System.Drawing.Size(317, 108);
			this.Controls.Add(this.Version);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.HideButton);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.Run);
			this.Controls.Add(this.Title);
			this.Controls.Add(this.Args);
			this.Controls.Add(this.Command);
			this.Controls.Add(this.Exit);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "MainWindow";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Text = "QuickRun";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Exit;
		private System.Windows.Forms.TextBox Command;
		private System.Windows.Forms.TextBox Args;
		private System.Windows.Forms.Label Title;
		private System.Windows.Forms.Button Run;
		private System.Windows.Forms.NotifyIcon Trayicon;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button HideButton;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label Version;
	}
}

