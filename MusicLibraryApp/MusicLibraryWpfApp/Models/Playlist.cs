using System.Collections.Generic;
using System.Windows.Media.Imaging;

namespace MusicLibraryWpfApp.Models
{
    public class Playlist
    {
        public Playlist(BitmapImage playlistArt, string name, string description, List<Song> songs)
        {
            PlaylistArt = playlistArt;
            Name = name;
            Description = description;
            Songs = songs;
        }

        public BitmapImage PlaylistArt { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<Song> Songs { get; set; } = new List<Song>();
    }
}