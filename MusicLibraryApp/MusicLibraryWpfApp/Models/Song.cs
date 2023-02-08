using System;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace MusicLibraryWpfApp.Models
{
    public class Song
    {
        public Song()
        {

        }

        public Song(string title, string artist, string albumTitle, BitmapImage art, TimeSpan length)
        {
            Title = title;
            Artist = artist;
            AlbumTitle = albumTitle;
            AlbumArt = art;
            Length = length;
        }

        public string Title { get; set; }

        public string Artist { get; set; }
       
        public string AlbumTitle { get; set; }
     
        public BitmapImage AlbumArt { get; set; }
    
        public TimeSpan Length { get; set; }
    }
}