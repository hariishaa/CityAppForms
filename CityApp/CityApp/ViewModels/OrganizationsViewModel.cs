using CityApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityApp.ViewModels
{
    public class OrganizationsViewModel : ViewModelBase
    {
        // public ObservableCollection<Organization> Organizations { get; private set; }
        public ObservableCollection<DTO.Company> Organizations { get; private set; }

        public OrganizationsViewModel(string category)
        {
            Title = category;
            // todo: remove this later
            if (category == "Финансы")
            {
                string atmsData = Properties.Resources.json;
                var organizations = JsonConvert.DeserializeObject<List<DTO.Company>>(atmsData);
                Organizations = new ObservableCollection<DTO.Company>(organizations);
            }
            // var organizations = Organization.GetFakeOrganizations().Where((o) => o.Category == category);
            //Organizations = new ObservableCollection<Organization>(organizations);
        }
    }
}
