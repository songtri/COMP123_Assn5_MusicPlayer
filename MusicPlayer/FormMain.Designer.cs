namespace MusicPlayer
{
	partial class MusicPlayer
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.PictureAlbum = new System.Windows.Forms.PictureBox();
			this.BtnStop = new System.Windows.Forms.Button();
			this.SliderPlaying = new System.Windows.Forms.TrackBar();
			this.BtnPrev = new System.Windows.Forms.Button();
			this.BtnNext = new System.Windows.Forms.Button();
			this.TrbVolume = new System.Windows.Forms.TrackBar();
			this.DgrPlaylist = new System.Windows.Forms.DataGridView();
			this.LblAlbumName = new System.Windows.Forms.Label();
			this.LblPlayingTime = new System.Windows.Forms.Label();
			this.ChkRepeatMode = new System.Windows.Forms.CheckBox();
			this.ChkShuffle = new System.Windows.Forms.CheckBox();
			this.RadioRepeatSong = new System.Windows.Forms.RadioButton();
			this.GrpRepeatMode = new System.Windows.Forms.GroupBox();
			this.RadioRepeatAll = new System.Windows.Forms.RadioButton();
			this.ComboSortPlaylist = new System.Windows.Forms.ComboBox();
			this.GrpPlaylist = new System.Windows.Forms.GroupBox();
			this.BtnEdit = new System.Windows.Forms.Button();
			this.BtnSearchPlaylist = new System.Windows.Forms.Button();
			this.TxtSearchPlaylist = new System.Windows.Forms.TextBox();
			this.BtnCreatePlaylist = new System.Windows.Forms.Button();
			this.BtnLoadPlaylist = new System.Windows.Forms.Button();
			this.BtnPlay = new System.Windows.Forms.Button();
			this.LblArtistName = new System.Windows.Forms.Label();
			this.LblSongName = new System.Windows.Forms.Label();
			this.GrpSongInfo = new System.Windows.Forms.GroupBox();
			this.OpenPlaylistFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.PlaytimeTrackTimer = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.PictureAlbum)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SliderPlaying)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TrbVolume)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DgrPlaylist)).BeginInit();
			this.GrpRepeatMode.SuspendLayout();
			this.GrpPlaylist.SuspendLayout();
			this.GrpSongInfo.SuspendLayout();
			this.SuspendLayout();
			// 
			// PictureAlbum
			// 
			this.PictureAlbum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.PictureAlbum.Location = new System.Drawing.Point(5, 5);
			this.PictureAlbum.Name = "PictureAlbum";
			this.PictureAlbum.Size = new System.Drawing.Size(250, 250);
			this.PictureAlbum.TabIndex = 0;
			this.PictureAlbum.TabStop = false;
			// 
			// BtnStop
			// 
			this.BtnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.BtnStop.Location = new System.Drawing.Point(40, 410);
			this.BtnStop.Name = "BtnStop";
			this.BtnStop.Size = new System.Drawing.Size(30, 30);
			this.BtnStop.TabIndex = 1;
			this.BtnStop.Text = "■";
			this.BtnStop.UseVisualStyleBackColor = true;
			this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
			// 
			// SliderPlaying
			// 
			this.SliderPlaying.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.SliderPlaying.AutoSize = false;
			this.SliderPlaying.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.SliderPlaying.Location = new System.Drawing.Point(5, 382);
			this.SliderPlaying.Margin = new System.Windows.Forms.Padding(0);
			this.SliderPlaying.Maximum = 1000;
			this.SliderPlaying.Name = "SliderPlaying";
			this.SliderPlaying.Size = new System.Drawing.Size(240, 25);
			this.SliderPlaying.TabIndex = 3;
			this.SliderPlaying.TabStop = false;
			this.SliderPlaying.TickFrequency = 0;
			this.SliderPlaying.TickStyle = System.Windows.Forms.TickStyle.None;
			this.SliderPlaying.Scroll += new System.EventHandler(this.SliderPlaying_Scroll);
			// 
			// BtnPrev
			// 
			this.BtnPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.BtnPrev.Location = new System.Drawing.Point(75, 410);
			this.BtnPrev.Name = "BtnPrev";
			this.BtnPrev.Size = new System.Drawing.Size(30, 30);
			this.BtnPrev.TabIndex = 2;
			this.BtnPrev.Text = "❚◀";
			this.BtnPrev.UseVisualStyleBackColor = true;
			this.BtnPrev.Click += new System.EventHandler(this.BtnPrev_Click);
			// 
			// BtnNext
			// 
			this.BtnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.BtnNext.Location = new System.Drawing.Point(110, 410);
			this.BtnNext.Name = "BtnNext";
			this.BtnNext.Size = new System.Drawing.Size(30, 30);
			this.BtnNext.TabIndex = 3;
			this.BtnNext.Text = "▶❚";
			this.BtnNext.UseVisualStyleBackColor = true;
			this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
			// 
			// TrbVolume
			// 
			this.TrbVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.TrbVolume.AutoSize = false;
			this.TrbVolume.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.TrbVolume.Location = new System.Drawing.Point(145, 412);
			this.TrbVolume.Margin = new System.Windows.Forms.Padding(0);
			this.TrbVolume.Maximum = 1000;
			this.TrbVolume.Name = "TrbVolume";
			this.TrbVolume.Size = new System.Drawing.Size(100, 25);
			this.TrbVolume.TabIndex = 6;
			this.TrbVolume.TabStop = false;
			this.TrbVolume.TickFrequency = 0;
			this.TrbVolume.TickStyle = System.Windows.Forms.TickStyle.None;
			// 
			// DgrPlaylist
			// 
			this.DgrPlaylist.AllowUserToAddRows = false;
			this.DgrPlaylist.AllowUserToDeleteRows = false;
			this.DgrPlaylist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.DgrPlaylist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.DgrPlaylist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.DgrPlaylist.BackgroundColor = System.Drawing.Color.Beige;
			this.DgrPlaylist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DgrPlaylist.Location = new System.Drawing.Point(3, 79);
			this.DgrPlaylist.Name = "DgrPlaylist";
			this.DgrPlaylist.ReadOnly = true;
			this.DgrPlaylist.RowHeadersWidth = 5;
			this.DgrPlaylist.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.DgrPlaylist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DgrPlaylist.Size = new System.Drawing.Size(244, 358);
			this.DgrPlaylist.TabIndex = 7;
			this.DgrPlaylist.TabStop = false;
			this.DgrPlaylist.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgrPlaylist_DataBindingComplete);
			// 
			// LblAlbumName
			// 
			this.LblAlbumName.AutoSize = true;
			this.LblAlbumName.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblAlbumName.Location = new System.Drawing.Point(6, 12);
			this.LblAlbumName.Name = "LblAlbumName";
			this.LblAlbumName.Size = new System.Drawing.Size(79, 15);
			this.LblAlbumName.TabIndex = 8;
			this.LblAlbumName.Text = "Album Name";
			this.LblAlbumName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// LblPlayingTime
			// 
			this.LblPlayingTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.LblPlayingTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.LblPlayingTime.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblPlayingTime.Location = new System.Drawing.Point(110, 357);
			this.LblPlayingTime.Name = "LblPlayingTime";
			this.LblPlayingTime.Size = new System.Drawing.Size(135, 20);
			this.LblPlayingTime.TabIndex = 9;
			this.LblPlayingTime.Text = "00:00:00 / 00:00:00";
			this.LblPlayingTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ChkRepeatMode
			// 
			this.ChkRepeatMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.ChkRepeatMode.AutoCheck = false;
			this.ChkRepeatMode.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ChkRepeatMode.Location = new System.Drawing.Point(5, 332);
			this.ChkRepeatMode.Name = "ChkRepeatMode";
			this.ChkRepeatMode.Size = new System.Drawing.Size(97, 20);
			this.ChkRepeatMode.TabIndex = 10;
			this.ChkRepeatMode.Text = "Repeat Mode";
			this.ChkRepeatMode.UseVisualStyleBackColor = true;
			this.ChkRepeatMode.Click += new System.EventHandler(this.ChkRepeatMode_Click);
			// 
			// ChkShuffle
			// 
			this.ChkShuffle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.ChkShuffle.AutoCheck = false;
			this.ChkShuffle.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ChkShuffle.Location = new System.Drawing.Point(5, 357);
			this.ChkShuffle.Name = "ChkShuffle";
			this.ChkShuffle.Size = new System.Drawing.Size(80, 20);
			this.ChkShuffle.TabIndex = 13;
			this.ChkShuffle.Text = "Shuffle";
			this.ChkShuffle.UseVisualStyleBackColor = true;
			this.ChkShuffle.Click += new System.EventHandler(this.ChkShuffle_Click);
			// 
			// RadioRepeatSong
			// 
			this.RadioRepeatSong.AutoSize = true;
			this.RadioRepeatSong.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RadioRepeatSong.Location = new System.Drawing.Point(5, 10);
			this.RadioRepeatSong.Name = "RadioRepeatSong";
			this.RadioRepeatSong.Size = new System.Drawing.Size(53, 19);
			this.RadioRepeatSong.TabIndex = 11;
			this.RadioRepeatSong.TabStop = true;
			this.RadioRepeatSong.Text = "Song";
			this.RadioRepeatSong.UseVisualStyleBackColor = true;
			// 
			// GrpRepeatMode
			// 
			this.GrpRepeatMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.GrpRepeatMode.Controls.Add(this.RadioRepeatAll);
			this.GrpRepeatMode.Controls.Add(this.RadioRepeatSong);
			this.GrpRepeatMode.Enabled = false;
			this.GrpRepeatMode.Location = new System.Drawing.Point(100, 322);
			this.GrpRepeatMode.Name = "GrpRepeatMode";
			this.GrpRepeatMode.Size = new System.Drawing.Size(130, 32);
			this.GrpRepeatMode.TabIndex = 15;
			this.GrpRepeatMode.TabStop = false;
			// 
			// RadioRepeatAll
			// 
			this.RadioRepeatAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.RadioRepeatAll.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RadioRepeatAll.Location = new System.Drawing.Point(70, 10);
			this.RadioRepeatAll.Name = "RadioRepeatAll";
			this.RadioRepeatAll.Size = new System.Drawing.Size(55, 17);
			this.RadioRepeatAll.TabIndex = 12;
			this.RadioRepeatAll.TabStop = true;
			this.RadioRepeatAll.Text = "All";
			this.RadioRepeatAll.UseVisualStyleBackColor = true;
			// 
			// ComboSortPlaylist
			// 
			this.ComboSortPlaylist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ComboSortPlaylist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboSortPlaylist.FormattingEnabled = true;
			this.ComboSortPlaylist.Location = new System.Drawing.Point(90, 22);
			this.ComboSortPlaylist.Name = "ComboSortPlaylist";
			this.ComboSortPlaylist.Size = new System.Drawing.Size(156, 23);
			this.ComboSortPlaylist.TabIndex = 7;
			this.ComboSortPlaylist.SelectedIndexChanged += new System.EventHandler(this.ComboSortPlaylist_SelectedIndexChanged);
			// 
			// GrpPlaylist
			// 
			this.GrpPlaylist.Controls.Add(this.BtnEdit);
			this.GrpPlaylist.Controls.Add(this.BtnSearchPlaylist);
			this.GrpPlaylist.Controls.Add(this.TxtSearchPlaylist);
			this.GrpPlaylist.Controls.Add(this.BtnCreatePlaylist);
			this.GrpPlaylist.Controls.Add(this.BtnLoadPlaylist);
			this.GrpPlaylist.Controls.Add(this.ComboSortPlaylist);
			this.GrpPlaylist.Controls.Add(this.DgrPlaylist);
			this.GrpPlaylist.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.GrpPlaylist.Location = new System.Drawing.Point(263, 0);
			this.GrpPlaylist.Name = "GrpPlaylist";
			this.GrpPlaylist.Size = new System.Drawing.Size(250, 440);
			this.GrpPlaylist.TabIndex = 18;
			this.GrpPlaylist.TabStop = false;
			this.GrpPlaylist.Text = "Playlist";
			// 
			// BtnEdit
			// 
			this.BtnEdit.AutoSize = true;
			this.BtnEdit.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnEdit.Location = new System.Drawing.Point(3, 50);
			this.BtnEdit.Name = "BtnEdit";
			this.BtnEdit.Size = new System.Drawing.Size(84, 27);
			this.BtnEdit.TabIndex = 6;
			this.BtnEdit.Text = "Edit Playlist";
			this.BtnEdit.UseVisualStyleBackColor = true;
			this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
			// 
			// BtnSearchPlaylist
			// 
			this.BtnSearchPlaylist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnSearchPlaylist.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnSearchPlaylist.Location = new System.Drawing.Point(217, 48);
			this.BtnSearchPlaylist.Name = "BtnSearchPlaylist";
			this.BtnSearchPlaylist.Size = new System.Drawing.Size(30, 27);
			this.BtnSearchPlaylist.TabIndex = 9;
			this.BtnSearchPlaylist.Text = "🔍 ";
			this.BtnSearchPlaylist.UseVisualStyleBackColor = true;
			this.BtnSearchPlaylist.Click += new System.EventHandler(this.BtnSearchPlaylist_Click);
			// 
			// TxtSearchPlaylist
			// 
			this.TxtSearchPlaylist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.TxtSearchPlaylist.Location = new System.Drawing.Point(94, 50);
			this.TxtSearchPlaylist.Name = "TxtSearchPlaylist";
			this.TxtSearchPlaylist.Size = new System.Drawing.Size(120, 23);
			this.TxtSearchPlaylist.TabIndex = 8;
			this.TxtSearchPlaylist.TextChanged += new System.EventHandler(this.TxtSearchPlaylist_TextChanged);
			this.TxtSearchPlaylist.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtSearchPlaylist_KeyUp);
			// 
			// BtnCreatePlaylist
			// 
			this.BtnCreatePlaylist.AutoSize = true;
			this.BtnCreatePlaylist.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnCreatePlaylist.Location = new System.Drawing.Point(40, 22);
			this.BtnCreatePlaylist.Name = "BtnCreatePlaylist";
			this.BtnCreatePlaylist.Size = new System.Drawing.Size(45, 27);
			this.BtnCreatePlaylist.TabIndex = 5;
			this.BtnCreatePlaylist.Text = "New";
			this.BtnCreatePlaylist.UseVisualStyleBackColor = true;
			this.BtnCreatePlaylist.Click += new System.EventHandler(this.BtnCreatePlaylist_Click);
			// 
			// BtnLoadPlaylist
			// 
			this.BtnLoadPlaylist.AutoSize = true;
			this.BtnLoadPlaylist.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnLoadPlaylist.Location = new System.Drawing.Point(3, 22);
			this.BtnLoadPlaylist.Name = "BtnLoadPlaylist";
			this.BtnLoadPlaylist.Size = new System.Drawing.Size(36, 27);
			this.BtnLoadPlaylist.TabIndex = 4;
			this.BtnLoadPlaylist.Text = "📂";
			this.BtnLoadPlaylist.UseVisualStyleBackColor = true;
			this.BtnLoadPlaylist.Click += new System.EventHandler(this.BtnLoadPlaylist_Click);
			// 
			// BtnPlay
			// 
			this.BtnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.BtnPlay.Location = new System.Drawing.Point(5, 410);
			this.BtnPlay.Name = "BtnPlay";
			this.BtnPlay.Size = new System.Drawing.Size(30, 30);
			this.BtnPlay.TabIndex = 0;
			this.BtnPlay.Text = "▶";
			this.BtnPlay.UseVisualStyleBackColor = true;
			this.BtnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
			// 
			// LblArtistName
			// 
			this.LblArtistName.AutoSize = true;
			this.LblArtistName.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblArtistName.Location = new System.Drawing.Point(6, 30);
			this.LblArtistName.Name = "LblArtistName";
			this.LblArtistName.Size = new System.Drawing.Size(71, 15);
			this.LblArtistName.TabIndex = 20;
			this.LblArtistName.Text = "Artist Name";
			this.LblArtistName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// LblSongName
			// 
			this.LblSongName.AutoSize = true;
			this.LblSongName.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblSongName.Location = new System.Drawing.Point(6, 48);
			this.LblSongName.Name = "LblSongName";
			this.LblSongName.Size = new System.Drawing.Size(79, 15);
			this.LblSongName.TabIndex = 21;
			this.LblSongName.Text = "Album Name";
			this.LblSongName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// GrpSongInfo
			// 
			this.GrpSongInfo.Controls.Add(this.LblAlbumName);
			this.GrpSongInfo.Controls.Add(this.LblSongName);
			this.GrpSongInfo.Controls.Add(this.LblArtistName);
			this.GrpSongInfo.Location = new System.Drawing.Point(5, 255);
			this.GrpSongInfo.Name = "GrpSongInfo";
			this.GrpSongInfo.Size = new System.Drawing.Size(250, 70);
			this.GrpSongInfo.TabIndex = 22;
			this.GrpSongInfo.TabStop = false;
			// 
			// OpenPlaylistFileDialog
			// 
			this.OpenPlaylistFileDialog.Filter = "\"jpl 파일\"|*.jpl";
			this.OpenPlaylistFileDialog.InitialDirectory = ".";
			this.OpenPlaylistFileDialog.Title = "Open Playlist File";
			// 
			// PlaytimeTrackTimer
			// 
			this.PlaytimeTrackTimer.Enabled = true;
			this.PlaytimeTrackTimer.Tick += new System.EventHandler(this.PlaytimeTrackTimer_Tick);
			// 
			// MusicPlayer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(518, 445);
			this.Controls.Add(this.GrpSongInfo);
			this.Controls.Add(this.BtnPlay);
			this.Controls.Add(this.GrpPlaylist);
			this.Controls.Add(this.GrpRepeatMode);
			this.Controls.Add(this.ChkShuffle);
			this.Controls.Add(this.ChkRepeatMode);
			this.Controls.Add(this.LblPlayingTime);
			this.Controls.Add(this.TrbVolume);
			this.Controls.Add(this.BtnNext);
			this.Controls.Add(this.BtnPrev);
			this.Controls.Add(this.SliderPlaying);
			this.Controls.Add(this.BtnStop);
			this.Controls.Add(this.PictureAlbum);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "MusicPlayer";
			this.Text = "MusicPlayer";
			((System.ComponentModel.ISupportInitialize)(this.PictureAlbum)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SliderPlaying)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TrbVolume)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DgrPlaylist)).EndInit();
			this.GrpRepeatMode.ResumeLayout(false);
			this.GrpRepeatMode.PerformLayout();
			this.GrpPlaylist.ResumeLayout(false);
			this.GrpPlaylist.PerformLayout();
			this.GrpSongInfo.ResumeLayout(false);
			this.GrpSongInfo.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox PictureAlbum;
		private System.Windows.Forms.Button BtnStop;
		private System.Windows.Forms.TrackBar SliderPlaying;
		private System.Windows.Forms.Button BtnPrev;
		private System.Windows.Forms.Button BtnNext;
		private System.Windows.Forms.TrackBar TrbVolume;
		private System.Windows.Forms.DataGridView DgrPlaylist;
		private System.Windows.Forms.Label LblAlbumName;
		private System.Windows.Forms.Label LblPlayingTime;
		private System.Windows.Forms.CheckBox ChkRepeatMode;
		private System.Windows.Forms.CheckBox ChkShuffle;
		private System.Windows.Forms.RadioButton RadioRepeatSong;
		private System.Windows.Forms.GroupBox GrpRepeatMode;
		private System.Windows.Forms.RadioButton RadioRepeatAll;
		private System.Windows.Forms.ComboBox ComboSortPlaylist;
		private System.Windows.Forms.GroupBox GrpPlaylist;
		private System.Windows.Forms.Button BtnPlay;
		private System.Windows.Forms.Label LblArtistName;
		private System.Windows.Forms.Label LblSongName;
		private System.Windows.Forms.GroupBox GrpSongInfo;
		private System.Windows.Forms.Button BtnLoadPlaylist;
		private System.Windows.Forms.Button BtnCreatePlaylist;
		private System.Windows.Forms.Button BtnSearchPlaylist;
		private System.Windows.Forms.TextBox TxtSearchPlaylist;
		private System.Windows.Forms.Button BtnEdit;
		private System.Windows.Forms.OpenFileDialog OpenPlaylistFileDialog;
		private System.Windows.Forms.Timer PlaytimeTrackTimer;
	}
}

