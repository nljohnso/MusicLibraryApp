using MusicLibraryWpfApp.Models;
using System;
using System.Windows.Media;

namespace MusicLibraryWpfApp.ViewModels
{
    public class SongViewModel : ViewModelBase
    {
        private string _title = string.Empty;
        private string _artist = string.Empty;
        private string _album = string.Empty;
        private ImageSource _albumArt;
        private TimeSpan _length;

        public SongViewModel(Song song)
        {
            Title = song.Title;
            Artist = song.Artist;
            Album = song.AlbumTitle;
            AlbumArt = song.AlbumArt;
            Length = song.Length;
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

        public string Album
        {
            get => _album;
            set
            {
                _album = value;
                NotifyPropertyChanged();
            }
        }

        public ImageSource AlbumArt
        {
            get => _albumArt;
            set
            {
                _albumArt = value;
                NotifyPropertyChanged();
            }
        }

        public TimeSpan Length
        {
            get => _length;
            set
            {
                _length = value;
                NotifyPropertyChanged();
            }
        }
    }
}