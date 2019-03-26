using System;
using System.Collections.Generic;
using MvvmCross.Forms.Views;
using Xamarin.Forms;
using DemoUI.ViewModels;
using MvvmCross.Forms.Presenters.Attributes;

namespace DemoUI.Pages
{
    [MvxTabbedPagePresentation(Position = TabbedPosition.Root)]
    public partial class HomePage : MvxTabbedPage<HomeViewModel>
    {
        public HomePage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

        }
    }
}
