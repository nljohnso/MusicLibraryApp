using System.Collections.Generic;
using System.Linq;

namespace MusicLibraryWpfApp.Models
{
    public class Library
    {
        public Library()
        {
            Albums = new List<Album>();
            Playlists = new List<Playlist>();
        }

        public List<Album> Albums { get; set; }

        public List<Playlist> Playlists { get; set; }

        public void AddSong(Song song)
        {
            Album album = Albums.FirstOrDefault(x => x.Title.Equals(song.AlbumTitle));
            if (album == null)
            {
                album = new Album()
                {
                    Title = song.AlbumTitle,
                    Artist = song.Artist,
                    AlbumArt = song.AlbumArt
                };

                Albums.Add(album);
            }

            album.Tracklist.Add(song);
        }
    }
}