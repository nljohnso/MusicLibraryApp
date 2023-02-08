using MusicLibraryWpfApp.ViewModels.Commands;
using MusicLibraryWpfApp.ViewModels.Pages;

namespace MusicLibraryWpfApp.ViewModels
{
    public class AppViewModel : ViewModelBase
    {
        private PageViewModel _currentPage;
        private HomePageViewModel _homeViewModel = new();
        private LibraryPageViewModel _libraryViewModel = new();

        public AppViewModel()
        {
            _homeViewModel.LibraryLoaded += HomeViewModel_LibraryLoaded;

            CurrentPage = _homeViewModel;
        }

        public PageViewModel CurrentPage
        {
            get => _currentPage;
            set
            {
                _currentPage = value;
                NotifyPropertyChanged();
            }
        }

        public LibraryViewModel Library { get; private set; }

        public SongViewModel ActiveSong { get; private set; }

        public void SetPage(PageTypes page)
        {
            switch (page)
            {
                case PageTypes.Home:
                    CurrentPage = _homeViewModel;
                    break;

                case PageTypes.Library:
                    CurrentPage = _libraryViewModel;
                    break;
            }
        }

        private void HomeViewModel_LibraryLoaded(object? sender, Models.Library e)
        {
            Library = new LibraryViewModel(e);

            _libraryViewModel.Albums = Library.Albums;
        }
    }
}