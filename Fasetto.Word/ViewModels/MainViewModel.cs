using Fasetto.Word.Core;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Input;

namespace Fasetto.Word
{
    public class MainViewModel : ViewModelBase
    {
        #region Private Member

        private Window mWindow;

        private int mOuterMarginSize = 10;
        private int mWindowRadius = 10;

        #endregion

        #region Public Properties

        public double WindowMinimumWidth { get; set; } = 400;
        public double WindowMinimumHeight { get; set; } = 400;

        public int ResizeBorder { get; set; } = 6;

        public Thickness ResizeBorderThickness => new Thickness(this.ResizeBorder + this.OuterMarginSize);
        public Thickness InnerContentPadding => new Thickness(this.ResizeBorder);

        public int OuterMarginSize
        {
            get => this.mWindow.WindowState == WindowState.Minimized ? 0 : this.mOuterMarginSize;
            set => this.mOuterMarginSize = value;
        }

        public Thickness OuterMaginSizeThickness => new Thickness(this.OuterMarginSize);

        public int WindowRadius
        {
            get => this.mWindow.WindowState == WindowState.Maximized ? 0 : this.mWindowRadius;
            set => this.mWindowRadius = value;
        }

        public CornerRadius WindowCornerRadius => new CornerRadius(this.WindowRadius);

        public int TitleHeight { get; set; } = 42;

        public GridLength TitleHeightGridLength => new GridLength(this.TitleHeight + this.ResizeBorder);

        public ApplicationPage CurrentPage { get; set; } = ApplicationPage.Login;

        #endregion

        #region Commands

        public ICommand MinimizeCommand { get; set; }

        public ICommand MaximizeCommand { get; set; }

        public ICommand CloseCommand { get; set; }

        public ICommand MenuCommand { get; set; }

        #endregion

        #region Constructor

        public MainViewModel()
        {
            this.mWindow = WindowHelper.GetWindow(typeof(MainWindow));

            this.mWindow.StateChanged += (sender, e) =>
            {
                this.RaisePropertyChanged(nameof(this.ResizeBorderThickness));
                this.RaisePropertyChanged(nameof(this.OuterMarginSize));
                this.RaisePropertyChanged(nameof(this.OuterMaginSizeThickness));
                this.RaisePropertyChanged(nameof(this.WindowRadius));
                this.RaisePropertyChanged(nameof(this.WindowCornerRadius));
            };


            this.MinimizeCommand = new RelayCommand(() => this.mWindow.WindowState = WindowState.Minimized);
            this.MaximizeCommand = new RelayCommand(() => this.mWindow.WindowState ^= WindowState.Maximized);
            this.CloseCommand = new RelayCommand(() => this.mWindow.Close());
            this.MenuCommand = new RelayCommand(() => SystemCommands.ShowSystemMenu(this.mWindow, GetMousePosition()));

            var resizer = new WindowResizer(this.mWindow);
        }

        #endregion

        #region Private Helpers

        private Point GetMousePosition()
        {
            var position = Mouse.GetPosition(this.mWindow);

            return new Point(position.X + this.mWindow.Left, position.Y + this.mWindow.Top);
        }

        #endregion
    }
}