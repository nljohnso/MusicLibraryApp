using System.Collections.ObjectModel;

namespace MusicLibraryWpfApp.ViewModels.Pages
{
    public class LibraryPageViewModel : PageViewModel
    {
        private AlbumViewModel _selectedAlbum;

        public LibraryPageViewModel()
        {
            Albums = new();
        }

        public override PageTypes PageType => PageTypes.Library;

        public ObservableCollection<AlbumViewModel> Albums { get; set; }

        public AlbumViewModel SelectedAlbum
        {
            get => _selectedAlbum;
            set
            {
                _selectedAlbum = value;
                NotifyPropertyChanged();
            }
        }
    }
}