using Fasetto.Word.Core;
using System.Security;

namespace Fasetto.Word
{
    /// <summary>
    /// LoginPage.xaml 的交互逻辑
    /// </summary>
    public partial class LoginPage : BasePage, IHavePassword
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        public SecureString SecurePassword => passwordText.SecurePassword;
    }
}
