using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DemoUI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        void Handle_Pressed(object sender, System.EventArgs e)
        {
            if (tfEmail.Text == "kn7" && tfPassword.Text == "123")
            {
                this.Navigation.PushAsync(new MainHome());
            }
            else
            {
                return;
            }

        }
    }
}
