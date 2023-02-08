namespace MusicLibraryWpfApp.ViewModels.Pages
{
    public abstract class PageViewModel : ViewModelBase
    {
        public virtual PageTypes PageType { get; }
    }
}