using CityApp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace CityApp.ViewModel
{
    public class TaxiViewModel : ViewModelBase
    {
        public ObservableCollection<Taxi> Taxis { get; private set; }

        public ICommand MakeACallCommand { get; private set; }

        public TaxiViewModel()
        {
            Title = "Такси";
            // todo: move taxis list to the server
            Taxis = new ObservableCollection<Taxi>(Taxi.GetFakeTaxiList());
            // todo: make a call directly
            // http://www.c-sharpcorner.com/UploadFile/e4bad6/code-to-start-call-in-xamarin-forms/
            // https://blog.falafel.com/dialing-a-number-in-xamarin-forms-using-dependencyservice/
            // https://stackoverflow.com/questions/37551576/how-to-make-a-phone-call-in-xamarin-forms-by-clicking-on-a-label
            // https://stackoverflow.com/questions/33880505/make-phone-call-directly-xamarin-forms
            // https://www.youtube.com/watch?v=szYSHnvnTrk
            // http://nugetmusthaves.com/Package/PhoneCall.Forms.Plugin
            MakeACallCommand = new Command((tel) => Device.OpenUri(new Uri("tel:" + tel.ToString())));
        }
    }
}
