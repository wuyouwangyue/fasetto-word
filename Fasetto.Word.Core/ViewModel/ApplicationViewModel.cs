using GalaSoft.MvvmLight;

namespace Fasetto.Word.Core
{
    public class ApplicationViewModel : ViewModelBase
    {
        public ApplicationPage CurrentPage { get; set; }

        public bool SideMenuVisile { get; set; } = true;

        public ApplicationViewModel()
        {
            this.CurrentPage = ApplicationPage.Rtegister;
        }
    }
}
