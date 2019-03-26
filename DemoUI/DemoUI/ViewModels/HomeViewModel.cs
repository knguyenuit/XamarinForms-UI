using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MvvmCross.ViewModels;
using MvvmCross.Navigation;
namespace DemoUI.ViewModels
{
    public class HomeViewModel : MvxViewModel
    {
        readonly IMvxNavigationService _navigationService;

        public HomeViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        #region Life

        public override void Prepare()
        {
            base.Prepare();
        }

        public override Task Initialize()
        {


            return base.Initialize();
        }

        bool _isFirstTime = true;

        public override async void ViewAppeared()
        {
            base.ViewAppeared();


            await Task.Delay(1000);

            await ShowInitialTab();

        }

        public override async void ViewAppearing()
        {

            base.ViewAppearing();
        }

        #endregion


        #region Methods

        public async Task ShowInitialTab()
        {
            var tasks = new List<Task>();
            tasks.Add(_navigationService.Navigate<CalendarViewModel>());
            tasks.Add(_navigationService.Navigate<GoalsViewModel>());
            //tasks.Add(_navigationService.Navigate<SkillsViewModel>());
            //tasks.Add(_navigationService.Navigate<MoreViewModel>());
            await Task.WhenAll(tasks);

        }

        #endregion
    }
}
