using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using CityApp.Annotations;
using Xamarin.Forms;
using System.Windows.Input;
using CityApp.Views;

namespace CityApp.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public ICommand SetTitleCommand { private set; get; }
        public ICommand NavigateToPolyclinicPageCommand { get; private set; }
        public ICommand NavigateToTaxiPageCommand { get; private set; }
        public ICommand NavigateToOrganizationsCategoriesPageCommand { get; private set; }
        public ICommand NavigateToTelevisionPageCommand { get; private set; }

        public MainViewModel()
        {
            SetTitleCommand = new Command((title) => Title = title.ToString());
            // todo: change this navigation kostili
            NavigateToPolyclinicPageCommand = new Command(
                async (type) => await NavigateToPolyclinicPage(type));
            NavigateToTaxiPageCommand = new Command(
                async () => await Application.Current.MainPage.Navigation.PushAsync(new TaxiPage()));
            NavigateToOrganizationsCategoriesPageCommand = new Command(
                async () => await Application.Current.MainPage.Navigation.PushAsync(new OrganizationsCategoriesPage()));
            NavigateToTelevisionPageCommand = new Command(
                async () => await Application.Current.MainPage.Navigation.PushAsync(new TelevisionPage()));
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
