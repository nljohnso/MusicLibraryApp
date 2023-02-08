using MusicLibraryWpfApp.ViewModels;
using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace MusicLibraryWpfApp.Views.Converters
{
    public class SelectedAlbumToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value != null && value is AlbumViewModel ? Visibility.Visible : Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}