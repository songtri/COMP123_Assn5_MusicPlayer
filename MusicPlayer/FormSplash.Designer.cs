namespace MusicPlayer
{
	partial class FormSplash
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
			this.SplashLabel = new System.Windows.Forms.Label();
			this.SplashTimer = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// SplashLabel
			// 
			this.SplashLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SplashLabel.Font = new System.Drawing.Font("Freestyle Script", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SplashLabel.Location = new System.Drawing.Point(0, 0);
			this.SplashLabel.Margin = new System.Windows.Forms.Padding(0);
			this.SplashLabel.Name = "SplashLabel";
			this.SplashLabel.Size = new System.Drawing.Size(594, 294);
			this.SplashLabel.TabIndex = 0;
			this.SplashLabel.Text = "Music Player";
			this.SplashLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// SplashTimer
			// 
			this.SplashTimer.Enabled = true;
			this.SplashTimer.Tick += new System.EventHandler(this.SplashTimer_Tick);
			// 
			// FormSplash
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightGreen;
			this.ClientSize = new System.Drawing.Size(594, 294);
			this.ControlBox = false;
			this.Controls.Add(this.SplashLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "FormSplash";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label SplashLabel;
		private System.Windows.Forms.Timer SplashTimer;
	}
}