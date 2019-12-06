using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MusicPlayer
{
	public class Playlist
	{
		public List<Song> SongList { get; }
		public int SongCount { get => SongList.Count; }

		public Playlist()
		{
			SongList = new List<Song>();
		}

		public void AddSong(Song song)
		{
			if (song == null)
				return;

			if (SongList.Contains(song))
				return;

			SongList.Add(song);

			RearrangeTrackNumber();
		}

		public void RemoveSong(Song song)
		{
			if (song != null)
				SongList.Remove(song);

			RearrangeTrackNumber();
		}

		public void ChangeSongPosition(Song song, int newPosition)
		{
			RemoveSong(song);
			SongList.Insert(newPosition, song);
			RearrangeTrackNumber();
		}

		void RearrangeTrackNumber()
		{
			int index = 1;
			foreach (var song in SongList)
			{
				song.Track = index++;
			}
		}

		public void AddPlayilist(List<string> songFilePaths)
		{
			foreach (var filename in songFilePaths)
				AddSong(LoadTagInfo(filename));
		}

		public void LoadPlaylist(List<string> songFilePaths)
		{
			SongList.Clear();
			AddPlayilist(songFilePaths);
		}

		public Song LoadTagInfo(string filePath)
		{
			using (FileStream fs = File.OpenRead(filePath))
			{
				if (fs.Length >= 128)
				{
					MP3ID3Tag tag = new MP3ID3Tag(); // 클래스형인 tag 객체 초기화
					fs.Seek(-128, SeekOrigin.End);
					fs.Read(tag.TAGID, 0, tag.TAGID.Length);
					fs.Read(tag.Title, 0, tag.Title.Length);
					fs.Read(tag.Artist, 0, tag.Artist.Length);
					fs.Read(tag.Album, 0, tag.Album.Length);
					fs.Read(tag.Year, 0, tag.Year.Length);
					fs.Read(tag.Comment, 0, tag.Comment.Length);
					fs.Read(tag.Genre, 0, tag.Genre.Length);
					string theTAGID = Encoding.Default.GetString(tag.TAGID);

					if (theTAGID.Equals("TAG"))
					{
						string Title = Encoding.Default.GetString(tag.Title).Trim('\0');
						string Artist = Encoding.Default.GetString(tag.Artist).Trim('\0');
						string Album = Encoding.Default.GetString(tag.Album).Trim('\0');
						string Year = Encoding.Default.GetString(tag.Year).Trim('\0');
						string Comment = Encoding.Default.GetString(tag.Comment).Trim('\0');
						string Genre = Encoding.Default.GetString(tag.Genre).Trim('\0');

						if (string.IsNullOrEmpty(Title))
							Title = GetSongTitleFromFilePath(filePath);
						Song song = new Song(Album, Artist, Title, filePath, null);

						return song;
					}
					else
						return null;
				}
				else
					return null;
			}
		}

		private string GetSongTitleFromFilePath(string filePath)
		{
			var path = filePath.Split('\\');
			string filename = path[path.Length - 1];
			return filename.Replace(".mp3", "");
		}
	}

	class MP3ID3Tag
	{
		public byte[] TAGID = new byte[3];      //  3
		public byte[] Title = new byte[30];     //  30
		public byte[] Artist = new byte[30];    //  30
		public byte[] Album = new byte[30];     //  30
		public byte[] Year = new byte[4];       //  4
		public byte[] Comment = new byte[30];   //  30
		public byte[] Genre = new byte[1];      //  1
	}
}
