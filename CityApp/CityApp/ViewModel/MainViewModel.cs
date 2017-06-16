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

namespace CityApp.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public ICommand SetTitleCommand { private set; get; }
        public ICommand NavigateToPolyclinicPageCommand { get; private set; }

        public MainViewModel()
        {
            SetTitleCommand = new Command((title) => Title = title.ToString());
            NavigateToPolyclinicPageCommand = new Command(
                async (type) => await NavigateToPolyclinicPage(type)); // todo: change this kostil'
        }

        private async Task NavigateToPolyclinicPage(object type)
        {
            string baseUrl = "http://46.101.183.135/api";
            switch (type.ToString())
            {
                case "adult":
                    await Application.Current.MainPage.Navigation.PushAsync(new View.PolyclinicPage(
                            "Взрослая поликлиника", baseUrl + "/get_adult_polyclinic_timetable"));
                    break;
                case "children":
                    await Application.Current.MainPage.Navigation.PushAsync(new View.PolyclinicPage(
                            "Детская поликлиника", baseUrl + "/get_children_polyclinic_timetable"));
                    break;
                default:
                    break;
            }
        }
    }
}
