using System;
using MvvmCross.ViewModels;
using MvvmCross.Commands;
using System.Threading.Tasks;
using MvvmCross.Navigation;

namespace DemoUI.ViewModels
{
    public class LoginViewModel : MvxViewModel
    {
        readonly IMvxNavigationService _navigationService;

        public LoginViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        #region Binding Properties

        #region Email

        private string _email;
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                SetProperty(ref _email, value);
            }
        }

        #endregion

        #region Password

        private string _password;
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                SetProperty(ref _password, value);
            }
        }

        #endregion

        #endregion

        #region Commands

        public IMvxAsyncCommand LoginCommand => new MvxAsyncCommand(Login);

        private async Task Login()
        {

            var result = await _navigationService.Navigate<HomeViewModel>();

            //if (this.Email == "kn7" && this.Password == "123")
            //{

            //}
            //else
            //{
            //    return;
            //}
        }
        #endregion
    }
}
