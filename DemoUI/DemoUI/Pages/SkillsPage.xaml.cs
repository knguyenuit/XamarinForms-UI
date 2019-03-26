using System;
using System.Collections.Generic;

using Xamarin.Forms;
using MvvmCross.Forms.Views;
using DemoUI.ViewModels;
using MvvmCross.Forms.Presenters.Attributes;

namespace DemoUI.Pages
{
    [MvxTabbedPagePresentation(WrapInNavigationPage = false, Title = "Skills", Icon = "icSkills.png")]
    public partial class SkillsPage : MvxContentPage<SkillsViewModel>
    {
        public SkillsPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}
