using System;
using System.Linq;
using System.Windows;

namespace Fasetto.Word
{
    public class WindowHelper
    {
        public static Window GetWindow(Type o)
        {
            return App.Current.Windows.Cast<Window>().FirstOrDefault(x => x.GetType().Equals(o));
        }
    }
}
