using MusicLibraryWpfApp.ViewModels.Pages;
using System;
using System.Globalization;
using System.Windows.Data;

namespace MusicLibraryWpfApp.Views.Converters
{
    public class SelectedPageToBoolConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value is PageViewModel selectedPage &&
                   parameter is PageTypes assignedPage &&
                   selectedPage.PageType == assignedPage;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}