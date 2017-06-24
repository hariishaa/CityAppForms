using CityApp.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CityApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrganizationDetailPage : ContentPage
    {
        public OrganizationDetailPage(DTO.Company company)
        {
            InitializeComponent();

            // BindingContext = new OrganizationDetailViewModel(company);
            BindingContext = company;
            LoadStaticMap(company);

            //company.properties.CompanyMetaData.address
        }

        public async void LoadStaticMap(DTO.Company company)
        {
            var lng = company.geometry.coordinates[0].ToString().Replace(",", ".");
            var lat = company.geometry.coordinates[1].ToString().Replace(",", ".");
            var zoom = 18;
            var url = $"https://static-maps.yandex.ru/1.x/?l=map&ll={lng},{lat}&z={zoom}&pt={lng},{lat},org&size=650,450";
            //var client = new HttpClient();
            //using (var response = await client.GetAsync(url))
            //{
            //    response.EnsureSuccessStatusCode();

            //    var imageAsBytes = await response.Content.ReadAsByteArrayAsync();
            //    Map.Source = ImageSource.FromStream(() => new MemoryStream(imageAsBytes));

            //    //using (var inputStream = await response.Content.ReadAsStreamAsync())
            //    //{
            //    //    Map.Source = ImageSource.FromStream(() => inputStream);
            //    //}
            //}
            Map.Source = new UriImageSource
            {
                CachingEnabled = true,
                CacheValidity = new TimeSpan(0, 2, 0),
                Uri = new Uri(url)
            };
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var im = sender as Image;
            await DisplayAlert("title", im.Width.ToString() + " " + im.Height.ToString(), "ok");
        }
    }
}