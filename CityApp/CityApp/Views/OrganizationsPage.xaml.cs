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
    public partial class OrganizationsPage : ContentPage
    {
        public OrganizationsPage(string category)
        {
            InitializeComponent();

            BindingContext = new OrganizationsViewModel(category);
        }

        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            // todo: move to viewmodel
            await Navigation.PushAsync(new OrganizationDetailPage((DTO.Company)e.Item));
        }
    }
}