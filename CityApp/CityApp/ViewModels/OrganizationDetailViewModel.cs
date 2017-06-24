using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityApp.ViewModels
{
    // todo: replace DTO.Company by Models.Organization
    public class OrganizationDetailViewModel : ViewModelBase
    {
        private DTO.Company _company;

        public DTO.Company Company
        {
            get { return _company; }
            private set
            {
                _company = value;
                OnPropertyChanged();
            }
        }

        public OrganizationDetailViewModel(DTO.Company company)
        {
            Title = company.properties.CompanyMetaData.name;
            Company = company;
        }
    }
}
