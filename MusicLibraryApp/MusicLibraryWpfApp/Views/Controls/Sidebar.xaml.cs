using MusicLibraryWpfApp.ViewModels;
using System.Windows.Controls;

namespace MusicLibraryWpfApp.Views.Controls
{
    /// <summary>
    /// Interaction logic for Sidebar.xaml
    /// </summary>
    public partial class Sidebar : UserControl
    {
        public Sidebar()
        {
            InitializeComponent();
        }

        private void MenuOption_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (sender is MenuOption menuOption && 
                menuOption.Tag is PageTypes page)
            {
                // set the currently selected page
                (DataContext as AppViewModel)!.SetPage(page);
            }
        }
    }
}