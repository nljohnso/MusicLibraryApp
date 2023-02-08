using MusicLibraryWpfApp.Models;
using System.Collections.ObjectModel;

namespace MusicLibraryWpfApp.ViewModels
{
    public class LibraryViewModel : ViewModelBase
    {
        private Library _musicLibrary;

        public LibraryViewModel(Library library)
        {
            _musicLibrary = library;

            Albums = new();
            foreach(Album album in _musicLibrary.Albums)
            {
                Albums.Add(new AlbumViewModel(album));
            }

            Playlists = new();
            foreach (Playlist playlist in _musicLibrary.Playlists)
            {
                Playlists.Add(new PlaylistViewModel(playlist));
            }
        }

        public ObservableCollection<AlbumViewModel> Albums { get; set; }
     
        public ObservableCollection<PlaylistViewModel> Playlists { get; set; }

        public void AddSong(Song song)
        {

        }
    }
}