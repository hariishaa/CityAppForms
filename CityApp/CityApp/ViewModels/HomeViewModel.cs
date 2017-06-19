using CityApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace CityApp.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        public ICommand NavigateToPolyclinicPageCommand { get; private set; }
        public ICommand NavigateToTaxiPageCommand { get; private set; }

        public HomeViewModel()
        {
            // todo: change this navigation kostili
            NavigateToPolyclinicPageCommand = new Command(
                async (type) => await NavigateToPolyclinicPage(type));
            NavigateToTaxiPageCommand = new Command(
                async () => await Application.Current.MainPage.Navigation.PushAsync(new TaxiPage()));
        }

        private async Task NavigateToPolyclinicPage(object type)
        {
            string baseUrl = "http://46.101.183.135/api";
            switch (type.ToString())
            {
                case "adult":
                    await Application.Current.MainPage.Navigation.PushAsync(new PolyclinicPage(
                            "Взрослая поликлиника", baseUrl + "/get_adult_polyclinic_timetable"));
                    break;
                case "children":
                    await Application.Current.MainPage.Navigation.PushAsync(new PolyclinicPage(
                            "Детская поликлиника", baseUrl + "/get_children_polyclinic_timetable"));
                    break;
                default:
                    break;
            }
        }
    }
}
