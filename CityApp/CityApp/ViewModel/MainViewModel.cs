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

        public MainViewModel()
        {
            SetTitleCommand = new Command((title) => Title = title.ToString());
        }
    }
}
