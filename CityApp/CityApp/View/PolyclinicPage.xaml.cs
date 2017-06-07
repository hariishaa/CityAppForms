using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CityApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PolyclinicPage : ContentPage
    {
        public PolyclinicPage()
        {
            InitializeComponent();
        }

        private void Cell_OnTapped(object sender, EventArgs e)
        {
            var view = ((ViewCell) sender).View;
            var grid = ((Grid) view).Children[4];
            grid.IsVisible = !grid.IsVisible;           
        }

        private async void MenuItem_OnClicked(object sender, EventArgs e)
        {
            await DisplayAlert("", "Info", "OK");
        }
    }
}