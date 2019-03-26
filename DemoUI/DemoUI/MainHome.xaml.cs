using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DemoUI
{
    public partial class MainHome : TabbedPage
    {
        public MainHome()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}
