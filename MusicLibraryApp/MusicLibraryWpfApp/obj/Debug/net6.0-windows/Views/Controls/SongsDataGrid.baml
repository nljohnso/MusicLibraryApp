   M S B A M L   `   `   `  ????M  IMusicLibraryWpfApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:MusicLibraryWpfApp.Views.Controls!MusicLibraryWpfApp.Views.Controls  5      Y1clr-namespace:MusicLibraryWpfApp.Views.Converters#MusicLibraryWpfApp.Views.Converters  5      5    /MusicLibraryWpfApp.Views.Controls.SongsDataGrid   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Alocal/clr-namespace:MusicLibraryWpfApp.Views.Controls     5      H
converters1clr-namespace:MusicLibraryWpfApp.Views.Converters     5        ? 	Resources  5
       ?? MergedDictionaries ?? Source@   :MusicLibraryWpfApp.Views.Converters.EmptyAlbumArtConverter   EmptyAlbumArtConverter?? 5   
    5      ?? 5      $ ..\StyleDictionary.xaml??6%   %   &	          5      60   5      .??5      &   System.Windows.Controls.DataGrid     	RowHeight$ 70Q?6   $   HorizontalScrollBarVisibility$ Disabled=?5       %? 
ScrollUnit$
 Item=?5         SelectionMode$ Single=?5         AutoGenerateColumns$ False??5         GridLinesVisibility$
 None=?5      	   CanUserAddRows$	 False??5      
   CanUserDeleteRows$
 False??5        DataGridStyle#??[ 5      ??5      ?? *	Tracklist+   Columns 5   
   4  .System.Windows.Controls.DataGridTemplateColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$	 Art??6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 70 62      
IsReadOnly$
 True??6=      CellTemplate 5      ?? 5      .R?5       ?? $??3q?6    ??6+   ?? *
AlbumArt+ ?? 	Converter# [  5!      5#      0  *System.Windows.Controls.DataGridTextColumn  5$      $ Title??6!   $ 3* 60      
FontFamily$ Tahoma)?5%   !      FontSize$ 20Q?65   $
 True??6C     PrimaryTextColor   
Foreground# [ 5&   !   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5$   ;   ?? *Title+5&   !     5'      $ Artist??6!   $ * 61   $ Tahoma)?5(   !   $ 20Q?65   $
 True??6C   # [ 5)   !    5'   ;   ?? *Artist+5)   !     5*      $ Album??6!   $ 2* 60   $ Tahoma)?5+   !   $ 20Q?65   $
 True??6C   # [ 5,   !    5*   ;   ?? *Album+5,   !     5-      $ Length??6!   $ * 61   $ Tahoma)?5.   !   $ 20Q?65   $
 True??6C   # [ 5/   !    5-   ;   ?? *Length+ ?? StringFormat$ mm\:ss??5/   !   51      52      