using System;
using System.Collections.Generic;

using Xamarin.Forms;
using MvvmCross.Forms.Views;
using DemoUI.ViewModels;
using MvvmCross.Forms.Presenters.Attributes;

namespace DemoUI.Pages
{
    [MvxTabbedPagePresentation(WrapInNavigationPage = false, Title = "Goals", Icon = "icGoals.png")]
    public partial class GoalsPage : MvxContentPage<GoalsViewModel>
    {
        public GoalsPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}
