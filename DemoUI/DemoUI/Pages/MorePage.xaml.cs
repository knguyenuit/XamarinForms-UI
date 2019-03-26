using System;
using System.Collections.Generic;

using Xamarin.Forms;
using MvvmCross.Forms.Views;
using DemoUI.ViewModels;
using MvvmCross.Forms.Presenters.Attributes;

namespace DemoUI.Pages
{
    [MvxTabbedPagePresentation(WrapInNavigationPage = false, Title = "More", Icon = "icMore.png")]
    public partial class MorePage : MvxContentPage<MoreViewModel>
    {
        public MorePage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}
