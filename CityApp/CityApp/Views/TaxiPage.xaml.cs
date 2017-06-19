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
    public partial class TaxiPage : ContentPage
    {
        public TaxiPage()
        {
            InitializeComponent();
        }

        private async void ViewCell_Tapped(object sender, EventArgs e)
        {
            var vc = sender as ViewCell;
            await DisplayAlert("title", vc.View.Height.ToString(), "ok");
        }

        private void ViewCell_Appearing(object sender, EventArgs e)
        {
            var viewCell = sender as ViewCell;
            var listView = viewCell.Parent as ListView;
            var items = listView.ItemsSource.Cast<object>().ToList();
            //listView.HeightRequest = 44 * items.Count + 1;
        }
    }
}