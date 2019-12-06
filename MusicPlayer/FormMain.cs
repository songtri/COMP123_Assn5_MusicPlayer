using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web.Script.Serialization;
using System.Windows.Forms;
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
		private Playlist Playlist = null;
		private Song CurrentSong = null;
		private readonly int InitialPlaylistWidth = 0;
		private WindowsMediaPlayerClass WindowsMediaPlayer = new WMPLib.WindowsMediaPlayerClass();
		private const int IntervalBetweenTransition = 500;
		private int transitionTime = 0;
		private bool prepareNextSong = false;
		private int[] ShuffleIndex;
		private int CurrentShuffleIndexPlaying;

		public MusicPlayer()
		{
			InitializeComponent();
			ShowSplashScreen();
			InitGui();
			InitialPlaylistWidth = DgrPlaylist.Width;
		}

		private void ShowSplashScreen()
		{
			using (FormSplash splash = new FormSplash())
			{
				splash.ShowDialog();
			}
		}

		private void InitShuffleIndex()
		{
			if (Playlist == null)
				return;

			ShuffleIndex = new int[DgrPlaylist.Rows.Count];
			for (int i = 0; i < ShuffleIndex.Length; ++i)
				ShuffleIndex[i] = i;

			CurrentShuffleIndexPlaying = 0;
		}

		private void MakeShuffleIndex()
		{
			Random random = new Random();
			for (int i = 0; i < DgrPlaylist.Rows.Count - 1; ++i)
			{
				int randNum = random.Next(0, DgrPlaylist.Rows.Count);
				int temp = ShuffleIndex[i];
				ShuffleIndex[i] = ShuffleIndex[randNum];
				ShuffleIndex[randNum] = temp;
			}
		}

		private void InitGui()
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
			WindowsMediaPlayer.OpenStateChange += WindowsMediaPlayer_OpenStateChange;
			WindowsMediaPlayer.PlayStateChange += WindowsMediaPlayer_PlayStateChange;
			WindowsMediaPlayer.PositionChange += WindowsMediaPlayer_PositionChange;
			WindowsMediaPlayer.autoStart = false;

			CurrentShuffleIndexPlaying = 0;
		}

		private void WindowsMediaPlayer_PositionChange(double oldPosition, double newPosition)
		{
			if (Playlist == null)
				return;

			if (WindowsMediaPlayer.currentItem != null)
			{
				LblPlayingTime.Text = $"{WindowsMediaPlayer.currentPositionString} / {WindowsMediaPlayer.currentItem.durationString}";
			}
		}

		private void WindowsMediaPlayer_PlayStateChange(int NewState)
		{
			WMPPlayState playState = (WMPPlayState)NewState;
			Debug.WriteLine(playState);
			if (playState == WMPPlayState.wmppsStopped)
			{
				transitionTime = 0;
				prepareNextSong = true;
			}
		}

		private void WindowsMediaPlayer_OpenStateChange(int NewState)
		{
			WMPOpenState openState = (WMPOpenState)NewState;
			Debug.WriteLine(openState);
			if (openState == WMPOpenState.wmposMediaOpen)
			{
				LblPlayingTime.Text = $"{WindowsMediaPlayer.currentPositionString} / {WindowsMediaPlayer.currentItem.durationString}";
			}
		}

		private void PlaySelectedRow()
		{
			if (DgrPlaylist.SelectedRows.Count <= 0)
				return;

			int index = DgrPlaylist.SelectedRows[0].Index;
			var song = DgrPlaylist.SelectedRows[0].DataBoundItem as Song;
			if (song != null)
				CurrentSong = song;
			WindowsMediaPlayer.URL = CurrentSong.FilePath;
			WindowsMediaPlayer.controls.play();
			SetSongInfo();
		}

		private void PlayNextSong()
		{
			if (ChkRepeatMode.Checked && RadioRepeatSong.Checked)
			{
				WindowsMediaPlayer.controls.play();
			}
			else if (ChkRepeatMode.Checked && RadioRepeatAll.Checked)
			{
				MoveSelection(1);
				PlaySelectedRow();
			}
			else
			{
				if (DgrPlaylist.SelectedRows[0].Index < DgrPlaylist.Rows.Count - 1)
				{
					MoveSelection(1);
					PlaySelectedRow();
				}
				else
				{
					ResetPlayList();
				}
			}
		}

		private void SetSongInfo()
		{
			LblAlbumName.Text = CurrentSong.Album;
			LblArtistName.Text = CurrentSong.Artist;
			LblSongName.Text = CurrentSong.Title;
			Text = $"MusicPlayer - {CurrentSong.Title}";
		}

		private bool MoveSelection(int movement)
		{
			int nextIndex;
			if (ChkShuffle.Checked)
			{
				CurrentShuffleIndexPlaying += movement;
				if (CurrentShuffleIndexPlaying < 0)
				{
					if (ChkRepeatMode.Checked && RadioRepeatAll.Checked)
						CurrentShuffleIndexPlaying = ShuffleIndex.Length - 1;
					else
						return false;
				}
				if (CurrentShuffleIndexPlaying > ShuffleIndex.Length - 1)
				{
					if (ChkRepeatMode.Checked && RadioRepeatAll.Checked)
						CurrentShuffleIndexPlaying = 0;
					else
						return false;
				}
				nextIndex = ShuffleIndex[CurrentShuffleIndexPlaying];
			}
			else
			{
				if (DgrPlaylist.SelectedRows.Count > 0)
					nextIndex = DgrPlaylist.SelectedRows[0].Index + movement;
				else
					nextIndex = 0;
			}

			if (nextIndex < 0)
			{
				if (ChkRepeatMode.Checked && RadioRepeatAll.Checked)
					nextIndex = DgrPlaylist.Rows.Count - 1;
				else
					return false;
			}
			if (nextIndex > DgrPlaylist.Rows.Count - 1)
			{
				if (ChkRepeatMode.Checked && RadioRepeatAll.Checked)
					nextIndex = 0;
				else
					return false;
			}

			DgrPlaylist.ClearSelection();
			DgrPlaylist.Rows[nextIndex].Selected = true;
			return true;
		}

		private void BtnPlay_Click(object sender, EventArgs e)
		{
			if (Playlist == null)
				return;

			if (WindowsMediaPlayer.playState == WMPPlayState.wmppsPlaying)
			{
				BtnPlay.Text = PlayText[0];
				WindowsMediaPlayer.controls.pause();
			}
			else if (WindowsMediaPlayer.playState == WMPPlayState.wmppsPaused)
			{
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

			ResetPlayList();
		}

		private void BtnPrev_Click(object sender, EventArgs e)
		{
			if (Playlist == null)
				return;

			if (DgrPlaylist.SelectedRows.Count <= 0)
				return;

			if (MoveSelection(-1))
				PlaySelectedRow();
		}

		private void BtnNext_Click(object sender, EventArgs e)
		{
			if (Playlist == null)
				return;

			if (MoveSelection(1))
				PlaySelectedRow();
		}

		private void ChkShuffle_Click(object sender, EventArgs e)
		{
			if (Playlist == null)
				return;

			ChkShuffle.Checked = !ChkShuffle.Checked;
			if (ChkShuffle.Checked)
			{
				MakeShuffleIndex();
				MoveSelection(0);
			}
			else
				InitShuffleIndex();
		}

		private void ResetPlayList()
		{
			WindowsMediaPlayer.controls.stop();
			DgrPlaylist.ClearSelection();
			DgrPlaylist.Rows[0].Selected = true;
			BtnPlay.Text = PlayText[0];
			CurrentSong = Playlist.SongList[0];
			SetSongInfo();
			InitShuffleIndex();
			if (ChkShuffle.Checked)
				MakeShuffleIndex();
		}

		private void BtnLoadPlaylist_Click(object sender, EventArgs e)
		{
			OpenPlaylistFileDialog.InitialDirectory = Application.StartupPath;
			if (DialogResult.OK == OpenPlaylistFileDialog.ShowDialog())
			{
				LoadPlaylist(OpenPlaylistFileDialog.FileName);
				ResetPlayList();
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

			RefreshList();
		}

		private void RefreshList()
		{
			SortMethod method = (SortMethod)ComboSortPlaylist.SelectedIndex;

			List<Song> songList = DgrPlaylist.DataSource as List<Song>;
			List<Song> sortedList = new List<Song>();

			switch (method)
			{
				case SortMethod.Default:
					sortedList.AddRange(songList);
					break;
				case SortMethod.DefaultReverse:
					sortedList.AddRange(songList);
					sortedList.Reverse();
					break;
				case SortMethod.Album:
					sortedList.AddRange(from s in songList orderby s.Album ascending select s);
					break;
				case SortMethod.AlbumReverse:
					sortedList.AddRange(from s in songList orderby s.Album descending select s);
					break;
				case SortMethod.Artist:
					sortedList.AddRange(from s in songList orderby s.Artist ascending select s);
					break;
				case SortMethod.ArtistReverse:
					sortedList.AddRange(from s in songList orderby s.Artist descending select s);
					break;
				case SortMethod.Song:
					sortedList.AddRange(from s in songList orderby s.Title ascending select s);
					break;
				case SortMethod.SongReverse:
					sortedList.AddRange(from s in songList orderby s.Title descending select s);
					break;
				default:
					break;
			}

			DgrPlaylist.DataSource = null;
			DgrPlaylist.DataSource = sortedList;

			DgrPlaylist.ClearSelection();
			foreach (DataGridViewRow s in DgrPlaylist.Rows)
			{
				var song = s.DataBoundItem as Song;
				if (song == CurrentSong)
					s.Selected = true;
			}

			InitShuffleIndex();
			if (ChkShuffle.Checked)
				MakeShuffleIndex();
		}

		public void ApplyPlaylist(Playlist playlist)
		{
			Playlist = playlist;

			DgrPlaylist.DataSource = null;
			DgrPlaylist.DataSource = Playlist.SongList;

			ResetPlayList();
		}

		private void ChkRepeatMode_Click(object sender, EventArgs e)
		{
			ChkRepeatMode.Checked = !ChkRepeatMode.Checked;
			GrpRepeatMode.Enabled = ChkRepeatMode.Checked;

			if (!RadioRepeatSong.Checked && !RadioRepeatAll.Checked)
				RadioRepeatSong.Checked = true;
		}

		private void PlaytimeTrackTimer_Tick(object sender, EventArgs e)
		{
			if (Playlist == null)
				return;

			if (WindowsMediaPlayer.currentItem != null)
			{
				string currentPosition;
				if (string.IsNullOrEmpty(WindowsMediaPlayer.currentPositionString))
					currentPosition = "00:00";
				else
					currentPosition = WindowsMediaPlayer.currentPositionString;
				LblPlayingTime.Text = $"{currentPosition} / {WindowsMediaPlayer.currentItem.durationString}";
				if(WindowsMediaPlayer.currentItem.duration > 0)
					SliderPlaying.Value = (int)(WindowsMediaPlayer.currentPosition / WindowsMediaPlayer.currentItem.duration * SliderPlaying.Maximum);
			}

			if (prepareNextSong)
			{
				transitionTime += PlaytimeTrackTimer.Interval;
				if (transitionTime > IntervalBetweenTransition)
				{
					PlayNextSong();
					prepareNextSong = false;
				}
			}
		}

		private void TxtSearchPlaylist_TextChanged(object sender, EventArgs e)
		{
			SearchSong();
		}

		private void TxtSearchPlaylist_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
				SearchSong();
		}

		private void BtnSearchPlaylist_Click(object sender, EventArgs e)
		{
			SearchSong();
		}

		private void SearchSong()
		{
			if (TxtSearchPlaylist.Text.Length <= 0)
			{
				DgrPlaylist.DataSource = null;
				DgrPlaylist.DataSource = Playlist.SongList;
				RefreshList();
			}
			else
			{
				string lowCaseSearchText = TxtSearchPlaylist.Text.ToLower();
				var list = from s
							in Playlist.SongList
							where s.Title.ToLower().Contains(lowCaseSearchText) || s.Album.ToLower().Contains(lowCaseSearchText) || s.Artist.ToLower().Contains(lowCaseSearchText)
							select s;
				List<Song> songList = new List<Song>(list);

				DgrPlaylist.DataSource = null;
				DgrPlaylist.DataSource = songList;

				RefreshList();
			}
		}

		private void SliderPlaying_Scroll(object sender, EventArgs e)
		{
			if (Playlist == null)
				return;

			if (WindowsMediaPlayer.currentItem != null)
			{
				double relativePosition = (double)SliderPlaying.Value / SliderPlaying.Maximum;
				double position = WindowsMediaPlayer.currentItem.duration * relativePosition;
				WindowsMediaPlayer.currentPosition = position;
			}
		}
	}
}
