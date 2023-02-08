using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace MusicLibraryWpfApp.Views.Converters
{
    public class SelectedToBackgroundColorConverter : IValueConverter
    {
        // Use this resource dictionary to access color brushes
        public ResourceDictionary ResourceDictionary { get; set; } = new ResourceDictionary();

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                bool isSelected = (bool)value;
                if (isSelected)
                {
                    return ResourceDictionary["PrimaryAccentColor"];
                }
            }
            catch
            {
                // ignore, just return primary text color
            }

            return ResourceDictionary["PrimaryTextColor"];
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}