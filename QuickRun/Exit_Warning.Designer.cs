namespace QuickRun
{
	partial class Exit_Warning
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exit_Warning));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.Exit_button = new System.Windows.Forms.Button();
			this.Cancel_button = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(12, 9);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(49, 53);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label1.Location = new System.Drawing.Point(67, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(146, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "Are you sure?";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(69, 34);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(183, 39);
			this.label2.TabIndex = 2;
			this.label2.Text = "Closing QuickRun will not run in the \r\nbackgound. Therefore you will not be\r\nable" +
    " to reopen it from the system tray";
			// 
			// Exit_button
			// 
			this.Exit_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
			this.Exit_button.ForeColor = System.Drawing.Color.White;
			this.Exit_button.Location = new System.Drawing.Point(180, 76);
			this.Exit_button.Name = "Exit_button";
			this.Exit_button.Size = new System.Drawing.Size(89, 29);
			this.Exit_button.TabIndex = 3;
			this.Exit_button.Text = "No, Quit now";
			this.Exit_button.UseVisualStyleBackColor = false;
			this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
			// 
			// Cancel_button
			// 
			this.Cancel_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
			this.Cancel_button.ForeColor = System.Drawing.Color.White;
			this.Cancel_button.Location = new System.Drawing.Point(85, 76);
			this.Cancel_button.Name = "Cancel_button";
			this.Cancel_button.Size = new System.Drawing.Size(89, 29);
			this.Cancel_button.TabIndex = 4;
			this.Cancel_button.Text = "Cancel";
			this.Cancel_button.UseVisualStyleBackColor = false;
			this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
			// 
			// Exit_Warning
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
			this.ClientSize = new System.Drawing.Size(273, 108);
			this.Controls.Add(this.Cancel_button);
			this.Controls.Add(this.Exit_button);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Exit_Warning";
			this.Text = "Form2";
			this.Load += new System.EventHandler(this.Form2_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button Exit_button;
		private System.Windows.Forms.Button Cancel_button;
	}
}