using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace Fasetto.Word
{
    public static class FrameworkElementAnimations
    {
        #region Slide And Fade In From Left/Right

        public static async Task SlideAndFadeInFromRightAsync(this FrameworkElement element, float seconds = 0.3f, bool keepMargin = true, int size = 0)
        {
            var sb = new Storyboard();

            sb.AddSlideFromRight(seconds, size != 0  ? size : element.ActualWidth, keepMargin:keepMargin);

            sb.AddFadeIn(seconds);

            sb.Begin(element);

            element.Visibility = System.Windows.Visibility.Visible;

            await Task.Delay((int)(seconds * 1000));
        }

        public static async Task SlideAndFadeInFromLeftAsync(this FrameworkElement element, float seconds = 0.3f, bool keepMargin = true, int size = 0)
        {
            var sb = new Storyboard();

            sb.AddSlideFromLeft(seconds, size != 0 ? size : element.ActualWidth, keepMargin: keepMargin);

            sb.AddFadeIn(seconds);

            sb.Begin(element);

            element.Visibility = System.Windows.Visibility.Visible;

            await Task.Delay((int)(seconds * 1000));
        }

        #endregion

        #region Slide And Fade Out To Left/Right

        public static async Task SlideAndFadeOutToRightAsync(this FrameworkElement element, float seconds = 0.3f, bool keepMargin = true, int size = 0)
        {
            var sb = new Storyboard();

            sb.AddSlideToRight(seconds, size != 0 ? size : element.ActualWidth, keepMargin: keepMargin);

            sb.AddFadeOut(seconds);

            sb.Begin(element);

            element.Visibility = System.Windows.Visibility.Visible;

            await Task.Delay((int)(seconds * 1000));
        }

        public static async Task SlideAndFadeOutToLeftAsync(this FrameworkElement element, float seconds = 0.3f, bool keepMargin = true, int size = 0)
        {
            var sb = new Storyboard();

            sb.AddSlideToLeft(seconds, size != 0 ? size : element.ActualWidth, keepMargin: keepMargin);

            sb.AddFadeOut(seconds);

            sb.Begin(element);

            element.Visibility = System.Windows.Visibility.Visible;

            await Task.Delay((int)(seconds * 1000));
        }

        #endregion
    }
}
