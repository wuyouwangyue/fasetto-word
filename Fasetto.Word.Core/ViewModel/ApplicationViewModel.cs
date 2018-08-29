using GalaSoft.MvvmLight;

namespace Fasetto.Word.Core
{
    public class ApplicationViewModel : ViewModelBase
    {
        public ApplicationPage CurrentPage { get; set; }

        public ApplicationViewModel()
        {
            this.CurrentPage = ApplicationPage.Rtegister;
        }
    }
}
