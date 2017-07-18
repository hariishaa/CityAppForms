using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CityApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TelevisionPage : ContentPage
    {
        public TelevisionPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            //var client = new HttpClient();
            //var url = new Uri("https://api.vk.com/method/?PARAMETERS&access_token=ACCESS_TOKEN&v=V")
            //var response = await client.GetAsync();
        }
    }
}