using MusicLibraryWpfApp.Models;
using MusicLibraryWpfApp.ViewModels.Commands;
using System;
using System.IO;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace MusicLibraryWpfApp.ViewModels.Pages
{
    public class HomePageViewModel : PageViewModel
    {
        private RelayCommand _openMusicDirectoryCommand;

        public override PageTypes PageType => PageTypes.Home;

        public event EventHandler<Library> LibraryLoaded;

        public RelayCommand OpenMusicDirectory
        {
            get
            {
                return _openMusicDirectoryCommand ??
                      (_openMusicDirectoryCommand = new RelayCommand(x =>
                      {
                          var fbd = new FolderBrowserForWPF.Dialog();
                          if (fbd.ShowDialog() == true)
                          {
                              LibraryLoaded?.Invoke(this, GetLibraryFromDirectory(fbd.FileName));
                          }
                      }));
            }
        }

        private Library GetLibraryFromDirectory(string directory)
        {
            Library lib = new Library();

            string[] mp3Files = Directory.GetFiles(directory, "*.mp3", SearchOption.AllDirectories);
            for (int i = 0; i < mp3Files.Length; i++)
            {
                try
                {
                    var song = TagLib.File.Create(mp3Files[i]);
                    if (song != null)
                    {
                        lib.AddSong(new Song()
                        {
                            Title = song.Tag.Title ?? "Untitled Song",
                            Artist = song.Tag.FirstPerformer ?? "Unknown Artist",
                            AlbumTitle = song.Tag.Album ?? "Untitled Album",
                            AlbumArt = GetAlbumArt(song.Tag.Pictures),
                            Length = song.Properties.Duration
                        });
                    }
                }
                catch
                {
                    //something went wrong, do not include song
                }
                
            }

            return lib;
        }

        private BitmapImage GetAlbumArt(TagLib.IPicture[] pictures)
        {
            BitmapImage bitmap = new BitmapImage();
            foreach (var picture in pictures)
            {
                if (picture.Data.Count > 0)
                {
                    try
                    {
                        // if we find any picture with data lets just use that
                        bitmap.BeginInit();
                        bitmap.StreamSource = new MemoryStream(picture.Data.Data);
                        bitmap.EndInit();
                    }
                    catch 
                    {
                        return new BitmapImage();
                    }
                    
                    break;
                }
            }

            return bitmap;
        }
    }
}