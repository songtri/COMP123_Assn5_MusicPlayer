using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace MusicPlayer
{
	public partial class FormEditPlaylist : Form
	{
		readonly Playlist Playlist = new Playlist();
		readonly int InitialWidth = 0;
		MusicPlayer MainWindow = null;

		public FormEditPlaylist()
		{
			InitializeComponent();
			InitialWidth = Width;
		}

		public FormEditPlaylist(MusicPlayer main) : this()
		{
			MainWindow = main;
		}

		public FormEditPlaylist(MusicPlayer main, Playlist playlist) : this(main)
		{
			Playlist = playlist;
			DgrPlaylist.DataSource = null;
			DgrPlaylist.DataSource = Playlist.SongList;
		}

		private void ResizeWindow()
		{
			int width = 0;
			foreach (DataGridViewColumn col in DgrPlaylist.Columns)
			{
				if (col.Visible)
					width += col.Width;
			}

			if (width > InitialWidth)
			{
				DgrPlaylist.Width = width + DgrPlaylist.RowHeadersWidth + DgrPlaylist.ColumnCount + 1;
				GrpPlaylist.Width = DgrPlaylist.Width + 8;
				Width = GrpPlaylist.Location.X + GrpPlaylist.Width + 20;
			}
		}

		private void BtnAddFile_Click(object sender, EventArgs e)
		{
			if (DialogResult.OK == OpenMp3FileDialog.ShowDialog())
			{
				Playlist.AddPlayilist(OpenMp3FileDialog.FileNames.ToList());
			}

			DgrPlaylist.DataSource = null;
			DgrPlaylist.DataSource = Playlist.SongList;
		}

		private void BtnDeleteFile_Click(object sender, EventArgs e)
		{
			List<Song> deleteList = new List<Song>();
			foreach (DataGridViewRow row in DgrPlaylist.SelectedRows)
				deleteList.Add(row.DataBoundItem as Song);

			foreach (var song in deleteList)
				Playlist.RemoveSong(song);

			DgrPlaylist.DataSource = null;
			DgrPlaylist.DataSource = Playlist.SongList;
			DgrPlaylist.ClearSelection();
		}

		private void ChangeSongPosition(Song song, int newPosition)
		{
			if (song == null)
				return;

			Playlist.ChangeSongPosition(song, newPosition);

			DgrPlaylist.DataSource = null;
			DgrPlaylist.DataSource = Playlist.SongList;
			DgrPlaylist.CurrentRow.Selected = false;
			DgrPlaylist.Rows[newPosition].Selected = true;
		}

		private Song GetSelectedSong()
		{
			if (DgrPlaylist.SelectedRows.Count > 1 || DgrPlaylist.SelectedRows.Count <= 0)
				return null;

			return DgrPlaylist.SelectedRows[0].DataBoundItem as Song;
		}

		private void BtnToTop_Click(object sender, EventArgs e)
		{
			ChangeSongPosition(GetSelectedSong(), 0);
		}

		private void BtnUp_Click(object sender, EventArgs e)
		{
			var song = GetSelectedSong();
			ChangeSongPosition(song, song.Track - 2);
		}

		private void BtnDown_Click(object sender, EventArgs e)
		{
			var song = GetSelectedSong();
			ChangeSongPosition(song, song.Track);
		}

		private void BtnToBottom_Click(object sender, EventArgs e)
		{
			ChangeSongPosition(GetSelectedSong(), Playlist.SongCount - 1);
		}

		private void BtnSavePlaylist_Click(object sender, EventArgs e)
		{
			SavePlaylistFileDialog.InitialDirectory = Application.StartupPath;
			if (DialogResult.OK == SavePlaylistFileDialog.ShowDialog())
			{
				using (StreamWriter writer = new StreamWriter(SavePlaylistFileDialog.FileName))
				{
					JavaScriptSerializer jsonSerializer = new JavaScriptSerializer();
					writer.Write(jsonSerializer.Serialize(Playlist.SongList.Select(x => x.FilePath)));
				}
			}
		}

		private void DgrPlaylist_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			DgrPlaylist.Columns["FilePath"].Visible = false;
			DgrPlaylist.AutoResizeColumns();

			ResizeWindow();
		}

		private void BtnLoadPlaylist_Click(object sender, EventArgs e)
		{
			OpenPlaylistFileDialog.InitialDirectory = Application.StartupPath;
			if (DialogResult.OK == OpenPlaylistFileDialog.ShowDialog())
			{
				LoadPlaylist(OpenPlaylistFileDialog.FileName);
			}
		
  }
		private void LoadPlaylist(string filename)
		{
			using (var reader = new StreamReader(filename))
			{
				JavaScriptSerializer jsonSerializer = new JavaScriptSerializer();
				var list = jsonSerializer.Deserialize<List<string>>(reader.ReadToEnd());
				if (list.Count > 0)
					Playlist.LoadPlaylist(list);
			}

			DgrPlaylist.DataSource = null;
			DgrPlaylist.DataSource = Playlist.SongList;
		}

		private void BtnApply_Click(object sender, EventArgs e)
		{
			MainWindow.ApplyPlaylist(Playlist);
		}
	}
}
