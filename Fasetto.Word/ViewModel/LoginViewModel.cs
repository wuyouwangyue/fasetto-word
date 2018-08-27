using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Fasetto.Word.ViewModel
{
    public class LoginViewModel : ViewModelBase
    {

        #region Public Properties

        public string Email { get; set; }

        public SecureString Password { get; set; }

        public bool LoginIsRunning { get; set; }

        #endregion

        #region Commands

        public ICommand LoginCommand { get; set; }

        #endregion

        #region Constructor

        public LoginViewModel()
        {
            LoginCommand = new RelayCommand<object>(async (parameter) => await Login(parameter));
        }

        #endregion

        public async Task Login(object parameter)
        {
            await this.RunCommand(() => this.LoginIsRunning, async () =>
            {
                await Task.Delay(1000);
                var s = (parameter as IHavePassword)?.SecurePassword.Unsecure();
            });
        }
    }
}
