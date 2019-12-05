using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace MusicPlayer
{
	public class Song
	{
		public int Track { get; set; }
		public string Title { get; set; }
		public string Artist { get; set; }
		public string Album { get; set; }
		public string FilePath { get; set; }
		byte[] AlbumCover { get; set; }

		public Song()
		{
		}

		public Song(string album, string artist, string title, string filepath, byte[] cover)
		{
			Album = album;
			Artist = artist;
			Title = title;
			FilePath = filepath;
			AlbumCover = cover;
		}

		public override bool Equals(object obj)
		{
			if (obj is Song song)
				return FilePath == song.FilePath;

			return false;
		}

		public override int GetHashCode()
		{
			return 1230029444 + EqualityComparer<string>.Default.GetHashCode(FilePath);
		}
	}
}
