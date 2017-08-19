using CityApp.Views;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace CityApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            CultureInfo culture = new CultureInfo("ru-RU");
            CultureInfo.DefaultThreadCurrentCulture = culture;

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
