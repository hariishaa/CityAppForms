﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CityApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CityApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        // todo: move all event handlers to viewmodel
        private async void Button_Clicked(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new PolyclinicRegistrationPage());
            var options = new Plugin.Share.Abstractions.BrowserOptions
            {
                ChromeShowTitle = true,
                // todo: set the ios options
            };
            await Plugin.Share.CrossShare.Current.OpenBrowser("https://uslugi.mosreg.ru/zdrav/", options);
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TransportPage());
        }
    }
}