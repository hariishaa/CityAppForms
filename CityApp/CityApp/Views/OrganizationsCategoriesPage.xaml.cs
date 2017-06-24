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
    public partial class OrganizationsCategoriesPage : ContentPage
    {
        public OrganizationsCategoriesPage()
        {
            InitializeComponent();
        }

        // replace by eventtoaction behavior???
        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            // todo: move to viewmodel
            await Navigation.PushAsync(new OrganizationsPage(e.Item.ToString()));
        }
    }
}