   M S B A M L   `   `   `  ????M  IMusicLibraryWpfApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:MusicLibraryWpfApp.Views.Controls!MusicLibraryWpfApp.Views.Controls  5      7 clr-namespace:MusicLibraryWpfAppMusicLibraryWpfApp  5      Y1clr-namespace:MusicLibraryWpfApp.Views.Converters#MusicLibraryWpfApp.Views.Converters  5      /    )MusicLibraryWpfApp.Views.Controls.Sidebar   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Alocal/clr-namespace:MusicLibraryWpfApp.Views.Controls     5      2enums clr-namespace:MusicLibraryWpfApp     5      H
converters1clr-namespace:MusicLibraryWpfApp.Views.Converters     5         BackgroundColor#???   5
        ? 	Resources  5       ?? MergedDictionaries ?? SourceE   ?MusicLibraryWpfApp.Views.Converters.SelectedPageToBoolConverter  SelectedPageToBoolConverter?? 5   
    5      ?? 5      $ ..\StyleDictionary.xaml??6%   %   &	         5      65   5      .??5      ?  ? RowDefinitions 5   
   ?? 5      ?? 5      $
??Auto ?6   ?? 5      $
??1.5* ?6   ?? 5      $
??Auto ?6   ?? 5      $
??Auto ?6   .+?5   
   ? -   5         ?Name$ MenuOptionsGrid??5       5      ?? 5      ?? 5      .+?5!      2   ,MusicLibraryWpfApp.Views.Controls.MenuOption  2   ,MusicLibraryWpfApp.Views.Controls.MenuOption   Click$ MenuOption_Click??5#      $??0??5!         Text$
 Home??6,      Image$ /Resources/home.png??5"      "   MusicLibraryWpfApp.PageTypes   Home
	 ? Tag#	 Z 5'      
   Selected
 5$      ?? *CurrentPage+ ?? 	Converter# [  ?? ConverterParameter# Z 5'        5(      $ MenuOption_Click??5*      $??1??5(      $ Library??6,   $ /Resources/library.png??5)         Library#	 Z 5.      
 5+      ?? *CurrentPage+# [ # Z 5.      5/      ?? 51   
   $??1??6   $
??10,0q?6!     SecondaryAccentColor#??[ 6/   ?? 55   
   $??3??6   $
??10,0q?6!   #??[ 6/   ?? 57   
   $??4??6   $??/Resources/empty-art.png??6   $
??Left=?6?   $??Bottom=?6Z   $??UniformToFill=?6u   58      59      