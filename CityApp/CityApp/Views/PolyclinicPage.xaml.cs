using CityApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CityApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PolyclinicPage : ContentPage
    {
        public PolyclinicPage(string title, string url)
        {
            InitializeComponent();

            BindingContext = new PolyclinicViewModel(title, url);
        }

        private void Cell_OnTapped(object sender, EventArgs e)
        {
            var view = ((ViewCell) sender).View;
            var grid = ((Grid) view).Children[4]; // todo: try to change this
            grid.IsVisible = !grid.IsVisible;           
        }

        // todo: change this
        private async void MenuItem_OnClicked(object sender, EventArgs e)
        {
            await DisplayAlert("", "Info", "OK");
        }
    }
}