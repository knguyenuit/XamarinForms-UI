using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Forms.Views;
using Xamarin.Forms;
using DemoUI.ViewModels;

namespace DemoUI.Pages
{
    public partial class LoginPage : MvxContentPage<LoginViewModel>
    {


        public LoginPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

        }

    }
}
