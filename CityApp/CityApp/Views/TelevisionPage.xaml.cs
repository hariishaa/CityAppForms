using CityApp.ViewModels;
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

            BindingContext = new TelevisionViewModel();
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var youtubeItem = e.Item as Models.YoutubeItem;
            Plugin.Share.CrossShare.Current.OpenBrowser("https://www.youtube.com/watch?v=" + youtubeItem?.VideoId);
        }
    }
}