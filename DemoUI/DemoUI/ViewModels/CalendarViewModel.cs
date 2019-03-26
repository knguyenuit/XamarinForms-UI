using System;
using MvvmCross.ViewModels;
using MvvmCross.Navigation;
namespace DemoUI.ViewModels
{
    public class CalendarViewModel : MvxViewModel<int, string>
    {
        readonly IMvxNavigationService _navigationService;

        public CalendarViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public override void Prepare(int parameter)
        {

        }
    }
}
