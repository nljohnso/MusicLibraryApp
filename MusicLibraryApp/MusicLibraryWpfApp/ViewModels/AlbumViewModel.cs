using MusicLibraryWpfApp.Models;
using System.Collections.ObjectModel;
using System.Windows.Media.Imaging;

namespace MusicLibraryWpfApp.ViewModels
{
    public class AlbumViewModel : ViewModelBase
    {
        private string _title = string.Empty;
        private string _artist = string.Empty;
        private BitmapImage _albumArt;

        public AlbumViewModel(Album album)
        {
            Title = album.Title;
            Artist = album.Artist;
            AlbumArt = album.AlbumArt;

            Tracklist = new();
            foreach (Song song in album.Tracklist)
            {
                Tracklist.Add(new SongViewModel(song));
            }
        }

        public string Title
        {
            get => _title;
            set
            {
                _title = value;
                NotifyPropertyChanged();
            }
        }

        public string Artist
        {
            get => _artist;
            set
            {
                _artist = value;
                NotifyPropertyChanged();
            }
        }

        public BitmapImage AlbumArt
        {
            get => _albumArt;
            set
            {
                _albumArt = value;
                NotifyPropertyChanged();
            }
        }

        public ObservableCollection<SongViewModel> Tracklist { get; set; }
    }
}