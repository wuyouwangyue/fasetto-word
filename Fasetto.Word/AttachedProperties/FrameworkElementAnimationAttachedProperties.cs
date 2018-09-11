using System.Windows;

namespace Fasetto.Word
{
    public abstract class AnimateBaseProperty<Parent> : BaseAttachedProperty<Parent, bool>
        where Parent : BaseAttachedProperty<Parent, bool>, new()
    {

        #region Public Properties

        public bool FirstLoad { get; set; } = true;

        #endregion

        public override void OnValueUpdated(DependencyObject sender, object value)
        {
            if (!(sender is FrameworkElement element))
                return;

            //if (sender.GetValue(ValueProperty) == value)
            //    return;


            if(this.FirstLoad)
            {
                RoutedEventHandler onLoaded = null;
                onLoaded = (s, e) => 
                {
                    element.Loaded -= onLoaded;

                    this.DoAnimation(element, (bool)value);

                    this.FirstLoad = false;
                };
                element.Loaded += onLoaded;
            }
            else
            {
                this.DoAnimation(element, (bool)value);
            }
        }

        protected virtual void DoAnimation(FrameworkElement element, bool value) { }
    }

    public class AnimateSlideInFromLeftProperty : AnimateBaseProperty<AnimateSlideInFromLeftProperty>
    {
        protected override async void DoAnimation(FrameworkElement element, bool value)
        {
            if (value)
                await element.SlideAndFadeInFromLeftAsync(0.8f, keepMargin:false);
            else
                await element.SlideAndFadeOutToLeftAsync(0.8f, keepMargin: false);
        }
    }
}
