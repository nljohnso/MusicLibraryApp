using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace MusicLibraryWpfApp.Views.Controls
{
    /// <summary>
    /// Interaction logic for MenuOption.xaml
    /// </summary>
    public partial class MenuOption : UserControl
    {
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(MenuOption), new PropertyMetadata(default(string)));

        public static readonly DependencyProperty ImageProperty =
            DependencyProperty.Register("Image", typeof(ImageSource), typeof(MenuOption), new PropertyMetadata(null));

        public static readonly DependencyProperty SelectedProperty =
            DependencyProperty.Register("Selected", typeof(bool), typeof(MenuOption), new PropertyMetadata(default(bool)));

        public MenuOption()
        {
            InitializeComponent();
        }

        public event EventHandler<RoutedEventArgs> Click;

        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }

        public ImageSource Image
        {
            get => (ImageSource)GetValue(ImageProperty);
            set => SetValue(ImageProperty, value);
        }

        public bool Selected
        {
            get => (bool)GetValue(SelectedProperty);
            set => SetValue(SelectedProperty, value);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Click?.Invoke(this, e);
        }
    }
}