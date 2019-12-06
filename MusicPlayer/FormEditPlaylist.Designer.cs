namespace MusicPlayer
{
	partial class FormEditPlaylist
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
			this.GrpPlaylist = new System.Windows.Forms.GroupBox();
			this.BtnApply = new System.Windows.Forms.Button();
			this.BtnLoadPlaylist = new System.Windows.Forms.Button();
			this.BtnSavePlaylist = new System.Windows.Forms.Button();
			this.BtnToBottom = new System.Windows.Forms.Button();
			this.BtnDown = new System.Windows.Forms.Button();
			this.BtnToTop = new System.Windows.Forms.Button();
			this.BtnUp = new System.Windows.Forms.Button();
			this.BtnDeleteFile = new System.Windows.Forms.Button();
			this.BtnAddFile = new System.Windows.Forms.Button();
			this.DgrPlaylist = new System.Windows.Forms.DataGridView();
			this.OpenMp3FileDialog = new System.Windows.Forms.OpenFileDialog();
			this.SavePlaylistFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.OpenPlaylistFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.GrpPlaylist.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DgrPlaylist)).BeginInit();
			this.SuspendLayout();
			// 
			// GrpPlaylist
			// 
			this.GrpPlaylist.Controls.Add(this.BtnApply);
			this.GrpPlaylist.Controls.Add(this.BtnLoadPlaylist);
			this.GrpPlaylist.Controls.Add(this.BtnSavePlaylist);
			this.GrpPlaylist.Controls.Add(this.BtnToBottom);
			this.GrpPlaylist.Controls.Add(this.BtnDown);
			this.GrpPlaylist.Controls.Add(this.BtnToTop);
			this.GrpPlaylist.Controls.Add(this.BtnUp);
			this.GrpPlaylist.Controls.Add(this.BtnDeleteFile);
			this.GrpPlaylist.Controls.Add(this.BtnAddFile);
			this.GrpPlaylist.Controls.Add(this.DgrPlaylist);
			this.GrpPlaylist.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.GrpPlaylist.Location = new System.Drawing.Point(0, 0);
			this.GrpPlaylist.Name = "GrpPlaylist";
			this.GrpPlaylist.Size = new System.Drawing.Size(264, 453);
			this.GrpPlaylist.TabIndex = 19;
			this.GrpPlaylist.TabStop = false;
			this.GrpPlaylist.Text = "Playlist";
			// 
			// BtnApply
			// 
			this.BtnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnApply.AutoSize = true;
			this.BtnApply.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnApply.Location = new System.Drawing.Point(200, 55);
			this.BtnApply.Name = "BtnApply";
			this.BtnApply.Size = new System.Drawing.Size(60, 30);
			this.BtnApply.TabIndex = 8;
			this.BtnApply.Text = "Apply";
			this.BtnApply.UseVisualStyleBackColor = true;
			this.BtnApply.Click += new System.EventHandler(this.BtnApply_Click);
			// 
			// BtnLoadPlaylist
			// 
			this.BtnLoadPlaylist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnLoadPlaylist.AutoSize = true;
			this.BtnLoadPlaylist.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnLoadPlaylist.Location = new System.Drawing.Point(180, 22);
			this.BtnLoadPlaylist.Name = "BtnLoadPlaylist";
			this.BtnLoadPlaylist.Size = new System.Drawing.Size(37, 29);
			this.BtnLoadPlaylist.TabIndex = 6;
			this.BtnLoadPlaylist.Text = "📂";
			this.BtnLoadPlaylist.UseVisualStyleBackColor = true;
			this.BtnLoadPlaylist.Click += new System.EventHandler(this.BtnLoadPlaylist_Click);
			// 
			// BtnSavePlaylist
			// 
			this.BtnSavePlaylist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnSavePlaylist.AutoSize = true;
			this.BtnSavePlaylist.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnSavePlaylist.Location = new System.Drawing.Point(219, 22);
			this.BtnSavePlaylist.Name = "BtnSavePlaylist";
			this.BtnSavePlaylist.Size = new System.Drawing.Size(37, 29);
			this.BtnSavePlaylist.TabIndex = 7;
			this.BtnSavePlaylist.Text = "💾";
			this.BtnSavePlaylist.UseVisualStyleBackColor = true;
			this.BtnSavePlaylist.Click += new System.EventHandler(this.BtnSavePlaylist_Click);
			// 
			// BtnToBottom
			// 
			this.BtnToBottom.AutoSize = true;
			this.BtnToBottom.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnToBottom.Location = new System.Drawing.Point(124, 55);
			this.BtnToBottom.Name = "BtnToBottom";
			this.BtnToBottom.Size = new System.Drawing.Size(61, 30);
			this.BtnToBottom.TabIndex = 5;
			this.BtnToBottom.Text = "Bottom";
			this.BtnToBottom.UseVisualStyleBackColor = true;
			this.BtnToBottom.Click += new System.EventHandler(this.BtnToBottom_Click);
			// 
			// BtnDown
			// 
			this.BtnDown.AutoSize = true;
			this.BtnDown.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnDown.Location = new System.Drawing.Point(87, 55);
			this.BtnDown.Name = "BtnDown";
			this.BtnDown.Size = new System.Drawing.Size(31, 30);
			this.BtnDown.TabIndex = 4;
			this.BtnDown.Text = "▼";
			this.BtnDown.UseVisualStyleBackColor = true;
			this.BtnDown.Click += new System.EventHandler(this.BtnDown_Click);
			// 
			// BtnToTop
			// 
			this.BtnToTop.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnToTop.Location = new System.Drawing.Point(3, 55);
			this.BtnToTop.Name = "BtnToTop";
			this.BtnToTop.Size = new System.Drawing.Size(40, 30);
			this.BtnToTop.TabIndex = 2;
			this.BtnToTop.Text = "Top";
			this.BtnToTop.UseVisualStyleBackColor = true;
			this.BtnToTop.Click += new System.EventHandler(this.BtnToTop_Click);
			// 
			// BtnUp
			// 
			this.BtnUp.AutoSize = true;
			this.BtnUp.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnUp.Location = new System.Drawing.Point(50, 55);
			this.BtnUp.Name = "BtnUp";
			this.BtnUp.Size = new System.Drawing.Size(31, 30);
			this.BtnUp.TabIndex = 3;
			this.BtnUp.Text = "▲";
			this.BtnUp.UseVisualStyleBackColor = true;
			this.BtnUp.Click += new System.EventHandler(this.BtnUp_Click);
			// 
			// BtnDeleteFile
			// 
			this.BtnDeleteFile.AutoSize = true;
			this.BtnDeleteFile.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnDeleteFile.Location = new System.Drawing.Point(38, 22);
			this.BtnDeleteFile.Name = "BtnDeleteFile";
			this.BtnDeleteFile.Size = new System.Drawing.Size(30, 30);
			this.BtnDeleteFile.TabIndex = 1;
			this.BtnDeleteFile.Text = "-";
			this.BtnDeleteFile.UseVisualStyleBackColor = true;
			this.BtnDeleteFile.Click += new System.EventHandler(this.BtnDeleteFile_Click);
			// 
			// BtnAddFile
			// 
			this.BtnAddFile.AutoSize = true;
			this.BtnAddFile.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnAddFile.Location = new System.Drawing.Point(3, 22);
			this.BtnAddFile.Name = "BtnAddFile";
			this.BtnAddFile.Size = new System.Drawing.Size(30, 30);
			this.BtnAddFile.TabIndex = 0;
			this.BtnAddFile.Text = "+";
			this.BtnAddFile.UseVisualStyleBackColor = true;
			this.BtnAddFile.Click += new System.EventHandler(this.BtnAddFile_Click);
			// 
			// DgrPlaylist
			// 
			this.DgrPlaylist.AllowUserToAddRows = false;
			this.DgrPlaylist.AllowUserToDeleteRows = false;
			this.DgrPlaylist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.DgrPlaylist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.DgrPlaylist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.DgrPlaylist.BackgroundColor = System.Drawing.Color.Beige;
			this.DgrPlaylist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DgrPlaylist.Location = new System.Drawing.Point(3, 92);
			this.DgrPlaylist.Name = "DgrPlaylist";
			this.DgrPlaylist.ReadOnly = true;
			this.DgrPlaylist.RowHeadersWidth = 5;
			this.DgrPlaylist.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.DgrPlaylist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DgrPlaylist.Size = new System.Drawing.Size(258, 358);
			this.DgrPlaylist.TabIndex = 7;
			this.DgrPlaylist.TabStop = false;
			this.DgrPlaylist.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgrPlaylist_DataBindingComplete);
			// 
			// OpenMp3FileDialog
			// 
			this.OpenMp3FileDialog.Filter = "\"mp3 파일\"|*.mp3";
			this.OpenMp3FileDialog.Multiselect = true;
			this.OpenMp3FileDialog.Title = "Open mp3 File";
			// 
			// SavePlaylistFileDialog
			// 
			this.SavePlaylistFileDialog.DefaultExt = "jpl";
			this.SavePlaylistFileDialog.Filter = "MusicPlayer Playlist File|*.jpl";
			this.SavePlaylistFileDialog.Title = "Save Playlist";
			// 
			// OpenPlaylistFileDialog
			// 
			this.OpenPlaylistFileDialog.Filter = "\"jpl 파일\"|*.jpl";
			this.OpenPlaylistFileDialog.InitialDirectory = ".";
			this.OpenPlaylistFileDialog.Title = "Open Playlist File";
			// 
			// FormEditPlaylist
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(264, 453);
			this.Controls.Add(this.GrpPlaylist);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormEditPlaylist";
			this.Text = "Edit Playlist";
			this.GrpPlaylist.ResumeLayout(false);
			this.GrpPlaylist.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.DgrPlaylist)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox GrpPlaylist;
		private System.Windows.Forms.Button BtnAddFile;
		private System.Windows.Forms.DataGridView DgrPlaylist;
		private System.Windows.Forms.Button BtnSavePlaylist;
		private System.Windows.Forms.Button BtnToBottom;
		private System.Windows.Forms.Button BtnDown;
		private System.Windows.Forms.Button BtnToTop;
		private System.Windows.Forms.Button BtnUp;
		private System.Windows.Forms.Button BtnDeleteFile;
		private System.Windows.Forms.OpenFileDialog OpenMp3FileDialog;
		private System.Windows.Forms.SaveFileDialog SavePlaylistFileDialog;
		private System.Windows.Forms.Button BtnLoadPlaylist;
		private System.Windows.Forms.OpenFileDialog OpenPlaylistFileDialog;
		private System.Windows.Forms.Button BtnApply;
	}
}