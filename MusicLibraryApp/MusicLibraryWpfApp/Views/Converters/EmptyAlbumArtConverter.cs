using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace MusicLibraryWpfApp.Views.Converters
{
    public class EmptyAlbumArtConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is BitmapImage albumArt)
            {
                if (albumArt.StreamSource == null ||
                    albumArt.StreamSource.Length == 0)
                {
                    return Properties.Resources.empty_art;
                }
            }

            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}