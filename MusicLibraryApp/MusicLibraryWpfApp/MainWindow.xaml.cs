using MusicLibraryWpfApp.ViewModels;
using System.Windows;

namespace MusicLibraryWpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DataContext = new AppViewModel();
        }
    }
}