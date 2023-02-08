using MusicLibraryWpfApp.ViewModels;
using MusicLibraryWpfApp.ViewModels.Pages;
using System.Windows.Controls;
using System.Windows.Input;

namespace MusicLibraryWpfApp.Views.Controls
{
    /// <summary>
    /// Interaction logic for CatalogListControl.xaml
    /// </summary>
    public partial class CatalogListControl : UserControl
    {
        public CatalogListControl()
        {
            InitializeComponent();
        }

        private void Border_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (sender is Border border &&
                border.DataContext is AlbumViewModel album &&
                DataContext is LibraryPageViewModel vm)
            {
                if (vm.SelectedAlbum?.Title.Equals(album.Title) == true)
                {
                    vm.SelectedAlbum = null;
                }
                else
                {
                    vm.SelectedAlbum = album;
                }
            }
        }
    }
}