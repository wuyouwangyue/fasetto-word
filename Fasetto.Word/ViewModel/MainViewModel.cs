using GalaSoft.MvvmLight;
using System.Windows;

namespace Fasetto.Word.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        #region Private Member

        private Window mWindow;

        private int mOuterMarginSize = 10;
        private int mWindowRadius = 10;

        #endregion

        #region Public Properties

        public int ResizeBorder { get; set; } = 6;

        public Thickness ResizeBorderThickness => new Thickness(this.ResizeBorder + this.OuterMarginSize);

        public int OuterMarginSize
        {
            get => mWindow.WindowState == WindowState.Minimized ? 0 : this.mOuterMarginSize;
            set => this.mOuterMarginSize = value;
        }

        public Thickness OuterMaginSizeThickness => new Thickness(this.OuterMarginSize);

        public int WindowRadius
        {
            get => mWindow.WindowState == WindowState.Maximized ? 0 : this.mWindowRadius;
            set => this.mWindowRadius = value;
        }

        public CornerRadius WindowCornerRadius => new CornerRadius(this.WindowRadius);

        public int TitleHeight { get; set; } = 42;

        public GridLength TitleHeightGridLength => new GridLength(this.TitleHeight + this.ResizeBorder);


        #endregion

        #region Constructor

        public MainViewModel()
        {
            mWindow = WindowHelper.GetWindow(typeof(MainWindow));

            mWindow.StateChanged += (sender, e) =>
            {
                this.RaisePropertyChanged(nameof(this.ResizeBorderThickness));
                this.RaisePropertyChanged(nameof(this.OuterMarginSize));
                this.RaisePropertyChanged(nameof(this.OuterMaginSizeThickness));
                this.RaisePropertyChanged(nameof(this.WindowRadius));
                this.RaisePropertyChanged(nameof(this.WindowCornerRadius));
            };
        }

        #endregion
    }
}