using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using MediaPlayer;
using WMPLib;

public enum SortMethod
{
	Default,
	DefaultReverse,
	Album,
	AlbumReverse,
	Artist,
	ArtistReverse,
	Song,
	SongReverse
}

namespace MusicPlayer
{
	public partial class MusicPlayer : Form
	{
		readonly string[] SortMethodText = { "Playlist Default (Ascending)", "Playlist Default (Descending)",
												"Album Name (Ascending)", "Album Name (Descending)",
												"Artist Name (Ascending)", "Artist Name (Descending)",
												"Song Name (Ascending)", "Song Name (Descending)"};
		readonly string[] PlayText = { "▶", "❚❚" };
		Playlist Playlist = null;
		Song CurrentSong = null;
		readonly int InitialPlaylistWidth = 0;
		MediaPlayerClass Player = new MediaPlayerClass();
		WindowsMediaPlayerClass WindowsMediaPlayer = new WMPLib.WindowsMediaPlayerClass();

		public MusicPlayer()
		{
			InitializeComponent();
			//ShowSplashScreen();
			InitGui();
			InitialPlaylistWidth = DgrPlaylist.Width;
		}

		void ShowSplashScreen()
		{
			using (FormSplash splash = new FormSplash())
			{
				splash.ShowDialog();
			}
		}

		void InitGui()
		{
			LblAlbumName.Text = string.Empty;
			LblArtistName.Text = string.Empty;
			LblSongName.Text = string.Empty;
			ChkRepeatMode.Checked = false;
			GrpRepeatMode.Enabled = false;
			ChkShuffle.Checked = false;
			SliderPlaying.Value = 0;
			TrbVolume.Value = 50;

			GrpPlaylist.Text = "Playlist - Not Loaded";
			ComboSortPlaylist.DataSource = SortMethodText;
			TxtSearchPlaylist.Text = string.Empty;
			DgrPlaylist.DataSource = null;

			Playlist = null;
			CurrentSong = null;
			BtnPlay.Text = PlayText[0];
			Player.PlayStateChange += OnPlayStateChanged;
			Player.OpenStateChange += Player_OpenStateChange;
			Player.ReadyStateChange += Player_ReadyStateChange;
			WindowsMediaPlayer.OpenStateChange += WindowsMediaPlayer_OpenStateChange;
			WindowsMediaPlayer.PlayStateChange += WindowsMediaPlayer_PlayStateChange;
			WindowsMediaPlayer.PositionChange += WindowsMediaPlayer_PositionChange;
		}

		private void WindowsMediaPlayer_PositionChange(double oldPosition, double newPosition)
		{
			LblPlayingTime.Text = $"{WindowsMediaPlayer.currentPositionString} / {WindowsMediaPlayer.currentItem.durationString}";
		}

		private void WindowsMediaPlayer_PlayStateChange(int NewState)
		{
			WMPPlayState playState = (WMPPlayState)NewState;
			//if(playState == WMPPlayState)
			Debug.WriteLine(playState);
		}

		private void WindowsMediaPlayer_OpenStateChange(int NewState)
		{
			WMPOpenState openState = (WMPOpenState)NewState;
			if (openState == WMPOpenState.wmposMediaOpen)
			{
				LblPlayingTime.Text = $"{WindowsMediaPlayer.currentPositionString} / {WindowsMediaPlayer.currentItem.durationString}";
				//LblPlayingTime.Text = $" 00:00:00/{(int)WindowsMediaPlayer.duration / 3600:D2}:{((int)Player.Duration / 60) % 60:D2}:{(int)Player.Duration % 60:D2}";
			}
		}

		private void Player_ReadyStateChange(MPReadyStateConstants ReadyState)
		{
			throw new NotImplementedException();
		}

		private void Player_OpenStateChange(int OldState, int NewState)
		{
		}

		private void PlaySelectedRow()
		{
			if (DgrPlaylist.SelectedRows.Count <= 0)
				return;

			int index = DgrPlaylist.SelectedRows[0].Index;
			//Player.Open(Playlist.SongList[index].FilePath);
			//Debug.WriteLine(Player.OpenState);
			//Player.Play();
			//CurrentSong = Playlist.SongList[index];
			//SetSongInfo();
			WindowsMediaPlayer.URL = Playlist.SongList[index].FilePath;
			WindowsMediaPlayer.controls.play();
		}

		private void SetSongInfo()
		{
			LblAlbumName.Text = CurrentSong.Album;
			LblArtistName.Text = CurrentSong.Artist;
			LblSongName.Text = CurrentSong.Title;
			Text = $"MusicPlayer - {CurrentSong.Title}";
			//LblPlayingTime.Text = $" 00:00:00/{(int)Player.Duration/3600:D2}:{((int)Player.Duration/60)%60:D2}:{(int)Player.Duration%60:D2}";
		}

		private void OnPlayStateChanged(int OldState, int NewState)
		{
			Player.Play();
		}

		private void BtnPlay_Click(object sender, EventArgs e)
		{
			if (Playlist == null)
				return;

			if (Player.PlayState == MPPlayStateConstants.mpPlaying || WindowsMediaPlayer.playState == WMPPlayState.wmppsPlaying)
			{
				//Player.Pause();
				BtnPlay.Text = PlayText[0];
				//Debug.WriteLine(Player.OpenState);
				WindowsMediaPlayer.controls.pause();
			}
			else if (Player.PlayState == MPPlayStateConstants.mpPaused || WindowsMediaPlayer.playState == WMPPlayState.wmppsPaused)
			{
				//Player.Play();
				WindowsMediaPlayer.controls.play();
				BtnPlay.Text = PlayText[1];
			}
			else
			{
				PlaySelectedRow();
				BtnPlay.Text = PlayText[1];
			}
		}

		private void BtnStop_Click(object sender, EventArgs e)
		{
			if (Playlist == null)
				return;

			//Player.Stop();
			WindowsMediaPlayer.controls.stop();
			DgrPlaylist.ClearSelection();
			DgrPlaylist.Rows[0].Selected = true;
			BtnPlay.Text = PlayText[0];
			CurrentSong = Playlist.SongList[0];
			SetSongInfo();
		}

		private void BtnPrev_Click(object sender, EventArgs e)
		{
			if (Playlist == null)
				return;

			if (DgrPlaylist.SelectedRows.Count <= 0)
				return;

			int selectedRowIndex = DgrPlaylist.SelectedRows[0].Index;
			if (selectedRowIndex <= 0)
				return;

			DgrPlaylist.ClearSelection();
			DgrPlaylist.Rows[selectedRowIndex - 1].Selected = true;

			PlaySelectedRow();
		}

		private void BtnNext_Click(object sender, EventArgs e)
		{
			if (Playlist == null)
				return;

			int selectedRowIndex = DgrPlaylist.SelectedRows[0].Index;
			if (selectedRowIndex >= DgrPlaylist.Rows.Count - 1)
				return;

			DgrPlaylist.ClearSelection();
			DgrPlaylist.Rows[selectedRowIndex + 1].Selected = true;

			PlaySelectedRow();
		}

		private void ChkRepeatMode_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void ChkShuffle_CheckedChanged(object sender, EventArgs e)
		{
			if (Playlist == null)
				return;
		}

		private void RadioRepeatSong_CheckedChanged(object sender, EventArgs e)
		{
			if (Playlist == null)
				return;
		}

		private void RadioRepeatAlbum_CheckedChanged(object sender, EventArgs e)
		{
			if (Playlist == null)
				return;
		}

		private void BtnLoadPlaylist_Click(object sender, EventArgs e)
		{
			OpenPlaylistFileDialog.InitialDirectory = Application.StartupPath;
			if (DialogResult.OK == OpenPlaylistFileDialog.ShowDialog())
			{
				LoadPlaylist(OpenPlaylistFileDialog.FileName);
				CurrentSong = Playlist.SongList[0];
				SetSongInfo();
			}
		}

		private void BtnCreatePlaylist_Click(object sender, EventArgs e)
		{
			using (FormEditPlaylist formEditPlaylist = new FormEditPlaylist(this))
			{
				formEditPlaylist.ShowDialog();
			}
		}

		private void LoadPlaylist(string filename)
		{
			using (var reader = new StreamReader(filename))
			{
				JavaScriptSerializer jsonSerializer = new JavaScriptSerializer();
				var list = jsonSerializer.Deserialize<List<string>>(reader.ReadToEnd());
				if (list.Count > 0)
				{
					Playlist = new Playlist();
					Playlist.LoadPlaylist(list);
				}
			}

			var paths = filename.Split('\\');
			var nameAndExtension = paths[paths.Length - 1].Split('.');
			GrpPlaylist.Text = $"Playlist - {nameAndExtension[0]}";
			DgrPlaylist.DataSource = null;
			DgrPlaylist.DataSource = Playlist.SongList;
		}

		private void DgrPlaylist_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			DgrPlaylist.Columns["FilePath"].Visible = false;
			DgrPlaylist.AutoResizeColumns();

			ResizeWindow();
		}

		private void ResizeWindow()
		{
			int width = 0;
			foreach (DataGridViewColumn col in DgrPlaylist.Columns)
			{
				if (col.Visible)
					width += col.Width;
			}

			if (width > InitialPlaylistWidth)
			{
				DgrPlaylist.Width = width + DgrPlaylist.RowHeadersWidth + DgrPlaylist.ColumnCount + 1;
				GrpPlaylist.Width = DgrPlaylist.Width + 8;
				Width = GrpPlaylist.Location.X + GrpPlaylist.Width + 20;
			}
		}

		private void BtnEdit_Click(object sender, EventArgs e)
		{
			if (Playlist == null)
				return;

			using (FormEditPlaylist formEditPlaylist = new FormEditPlaylist(this, Playlist))
			{
				formEditPlaylist.ShowDialog();
			}

			DgrPlaylist.DataSource = null;
			DgrPlaylist.DataSource = Playlist.SongList;
		}

		private void ComboSortPlaylist_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Playlist == null)
				return;

			SortMethod method = (SortMethod)ComboSortPlaylist.SelectedIndex;
			SortPlaylist(method);
		}

		private void SortPlaylist(SortMethod method)
		{
			var list = Playlist.SortSongList(method);

			DgrPlaylist.DataSource = null;
			DgrPlaylist.DataSource = list;
		}

		public void ApplyPlaylist(Playlist playlist)
		{
			Playlist = playlist;

			DgrPlaylist.DataSource = null;
			DgrPlaylist.DataSource = Playlist.SongList;
		}

		private void ChkRepeatMode_Click(object sender, EventArgs e)
		{
			if (Playlist == null)
				return;

			ChkRepeatMode.Checked = !ChkRepeatMode.Checked;
			GrpRepeatMode.Enabled = ChkRepeatMode.Checked;
		}

		private void PlaytimeTrackTimer_Tick(object sender, EventArgs e)
		{

		}
	}
}
