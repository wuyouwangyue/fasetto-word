using CommonServiceLocator;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Security;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Fasetto.Word.Core
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

        public ICommand RegisterComamnd { get; set; }

        #endregion

        #region Constructor

        public LoginViewModel()
        {
            this.LoginCommand = new RelayCommand<object>(async (parameter) => await LoginAsync(parameter));
            this.RegisterComamnd = new RelayCommand(async () => await RegisterAsync());
        }

        #endregion

        public async Task LoginAsync(object parameter)
        {
            await this.RunCommandAsync(() => this.LoginIsRunning, async () =>
            {
                await Task.Delay(1000);
                var s = (parameter as IHavePassword)?.SecurePassword.Unsecure();
            });
        }

        public async Task RegisterAsync()
        {
            //TODO Regitser

            await Task.Delay(1000);

            IoC.Get<ApplicationViewModel>().CurrentPage = ApplicationPage.Login;
        }
    }
}
