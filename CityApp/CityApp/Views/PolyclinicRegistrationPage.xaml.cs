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
    public partial class PolyclinicRegistrationPage : ContentPage
    {
        public PolyclinicRegistrationPage()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            await Progress.ProgressTo(0.95, 900, Easing.SinIn);
        }

        protected override bool OnBackButtonPressed()
        {
            if (Browser.CanGoBack)
            {
                Browser.GoBack();
                return true;
            }
            return false;
        }

        private async void Browser_Navigating(object sender, WebNavigatingEventArgs e)
        {
            Progress.IsVisible = true;
            await Progress.ProgressTo(0.95, 900, Easing.SinIn);
        }

        private void Browser_Navigated(object sender, WebNavigatedEventArgs e)
        {
            Progress.IsVisible = false;
            Progress.Progress = 0.15;
        }
    }
}