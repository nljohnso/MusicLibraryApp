using System.Collections.Generic;
using System.Windows.Media.Imaging;

namespace MusicLibraryWpfApp.Models
{
    public class Album
    {
        public Album()
        {
            Tracklist = new();
        }

        public Album(BitmapImage albumArt, string title, string artist, List<Song> songs)
            : this()
        {
            AlbumArt = albumArt;
            Title = title;
            Artist = artist;
            Tracklist = songs;
        }

        public string Title { get; set; } = string.Empty;
        public string Artist { get; set; } = string.Empty;
        public BitmapImage AlbumArt { get; set; }
        public List<Song> Tracklist { get; set; }
    }
}