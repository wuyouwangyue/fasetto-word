using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Fasetto.Word
{
    public class BasePage : Page
    {
        #region Public Properties

        public PageAnimationType PageLoadAnimation { get; set; } = PageAnimationType.SlideAndFadeInFromRight;

        public PageAnimationType PageUnLoadAnimation { get; set; } = PageAnimationType.SlideAndFadeOutToleft;

        public float SlideSeconds { get; set; } = 0.8f;

        #endregion

        #region Constructor

        public BasePage()
        {
            if (this.PageLoadAnimation != PageAnimationType.None)
                this.Visibility = System.Windows.Visibility.Collapsed;

            Loaded += this.BasePage_LoadedAsync;
        }


        #endregion

        #region Animation Load / Unload


        private async void BasePage_LoadedAsync(object sender, RoutedEventArgs e)
        {
            await AnimateInAsync();
        }

        public async Task AnimateInAsync()
        {
            if (this.PageLoadAnimation == PageAnimationType.None)
                return;

            switch(this.PageLoadAnimation)
            {
                case PageAnimationType.SlideAndFadeInFromRight:

                    await this.SlideAndFadeInFromRightAsync(this.SlideSeconds, size: (int)this.WindowWidth);

                    break;
            }
        }

        public async Task AnimateOutAsync()
        {
            if (this.PageUnLoadAnimation == PageAnimationType.None)
                return;

            switch(this.PageUnLoadAnimation)
            {
                case PageAnimationType.SlideAndFadeOutToleft:

                    await this.SlideAndFadeOutToLeftAsync(this.SlideSeconds);

                    break;
            }
        }

        #endregion
    }
}