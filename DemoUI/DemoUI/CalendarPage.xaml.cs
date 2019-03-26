using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace DemoUI
{
    public partial class CalendarPage : ContentPage
    {
        public ObservableCollection<VeggieViewModel> veggies { get; set; }
        public CalendarPage()
        {
            InitializeComponent();

            veggies = new ObservableCollection<VeggieViewModel>();
            veggies.Add(new VeggieViewModel { Name = "Mid-afternoon snack", Time = "at 03:15 PM", Image = "coffee.png" });
            veggies.Add(new VeggieViewModel { Name = "Lunch", Time = "at 14:25 PM", Image = "dinner.png" });
            veggies.Add(new VeggieViewModel { Name = "Mid-morning snack", Time = "at 03:43 AM", Image = "tea.png" });
            listView.ItemsSource = veggies;

        }
    }

    public class VeggieViewModel
    {
        public string Name { get; set; }
        public string Time { get; set; }
        public string Image { get; set; }
    }
}
