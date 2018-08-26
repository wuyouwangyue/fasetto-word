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
            if (PageLoadAnimation != PageAnimationType.None)
                Visibility = System.Windows.Visibility.Collapsed;

            Loaded += BasePage_LoadedAsync;
        }


        #endregion

        #region Animation Load / Unload


        private async void BasePage_LoadedAsync(object sender, RoutedEventArgs e)
        {
            await AnimateInAsync();
        }

        public async Task AnimateInAsync()
        {
            if (PageLoadAnimation == PageAnimationType.None)
                return;

            switch(PageLoadAnimation)
            {
                case PageAnimationType.SlideAndFadeInFromRight:

                    await this.SlideAndFadeInFromRightAsync(SlideSeconds);

                    break;
            }
        }

        public async Task AnimateOutAnsync()
        {
            if (PageUnLoadAnimation == PageAnimationType.None)
                return;

            switch(PageUnLoadAnimation)
            {
                case PageAnimationType.SlideAndFadeOutToleft:

                    await this.SlideAndFadeOutToLeftAsync(SlideSeconds);

                    break;
            }
        }

        #endregion
    }
}