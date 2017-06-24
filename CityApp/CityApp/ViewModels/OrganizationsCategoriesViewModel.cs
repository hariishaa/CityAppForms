using CityApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityApp.ViewModels
{
    public class OrganizationsCategoriesViewModel : ViewModelBase
    {
        public ObservableCollection<string> Categories { get; private set; }

        public OrganizationsCategoriesViewModel()
        {
            Title = "Организации";
            Categories = new ObservableCollection<string>(Organization.GetFakeCategories());
        }
    }
}
