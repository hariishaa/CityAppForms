using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CityApp.Model;
using System.Windows.Input;
using Xamarin.Forms;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using CityApp.Annotations;

namespace CityApp.ViewModel
{
    public class PolyclinicViewModel : ViewModelBase
    {
        public ObservableCollection<Doctor> Doctors { get; private set; }

        public ICommand LoadDataCommand { private set; get; }

        public PolyclinicViewModel(string title, string url)
        {
            #region TestData
            //Doctors = new ObservableCollection<Doctor>
            //{
            //    new Doctor
            //    {
            //        Speciality = "АНАЛИЗ КРОВИ БИОХИМИЯ",
            //        Name = "",
            //        Room = "403",
            //        Region = "",
            //        Monday = "приема нет",
            //        Tuesday = "приема нет",
            //        Wednesday = "08:00 - 09:30",
            //        Thursday = "приема нет",
            //        Friday = "приема нет",
            //        Remarks = ""
            //    },
            //    new Doctor
            //    {
            //        Speciality = "ВРАЧ-ТЕРАПЕВТ ПОДРОСТКОВЫЙ",
            //        Name = "Матулевский Н.А.",
            //        Room = "306",
            //        Region = "",
            //        Monday = "14:00 - 19:00",
            //        Tuesday = "14:00 - 18:00",
            //        Wednesday = "проф.день",
            //        Thursday = "14:00 - 18:00",
            //        Friday = "09:00 - 14:00",
            //        Remarks = ""
            //    },
            //    new Doctor
            //    {
            //        Speciality = "ПЕДИАТР",
            //        Name = "Гордеева Е.А.",
            //        Room = "407",
            //        Region = "11",
            //        Monday = "",
            //        Tuesday = "",
            //        Wednesday = "",
            //        Thursday = "",
            //        Friday = "",
            //        Remarks = "Учебный отпуск с 05.06 - 09.06.2017 приём ведёт Михина О.М."
            //    },
            //    new Doctor
            //    {
            //        Speciality = "ПЕДИАТР",
            //        Name = "Черникова Н.Н.",
            //        Room = "404",
            //        Region = "9",
            //        Monday = "",
            //        Tuesday = "",
            //        Wednesday = "",
            //        Thursday = "",
            //        Friday = "",
            //        Remarks = "Отпуск с 05.06 - 30.06.2017 прием ведёт Синкевич О.В."
            //    },
            //    new Doctor
            //    {
            //        Speciality = "ПЕДИАТР",
            //        Name = "Калинина О.Н.",
            //        Room = "412",
            //        Region = "10",
            //        Monday = "16:00 - 19:00",
            //        Tuesday = "08:30 - 11:30",
            //        Wednesday = "13:00 - 16:00",
            //        Thursday = "08:00 - 11:30",
            //        Friday = "13:00 - 16:00",
            //        Remarks = ""
            //    },
            //    new Doctor
            //    {
            //        Speciality = "РЕНТГЕН",
            //        Name = "",
            //        Room = "взрослая поликлиника",
            //        Region = "",
            //        Monday = "с 9:00 до 14:00",
            //        Tuesday = "с 9:00 до 14:00",
            //        Wednesday = "с 9:00 до 14:00",
            //        Thursday = "с 9:00 до 14:00",
            //        Friday = "с 9:00 до 14:00",
            //        Remarks = ""
            //    }
            //};
            #endregion
            Doctors = new ObservableCollection<Doctor>();
            Title = title;
            LoadDataCommand = new Command(async () => await LoadData(url));
        }

        private async Task LoadData(string url)
        {
            if (IsLoading)
                return;
            IsLoading = true;
            Doctors.Clear();
            // todo: проверка подключения https://metanit.com/sharp/xamarin/10.2.php
            var client = new HttpClient();
            var requestUri = new Uri(url);
            var response = await client.GetAsync(requestUri);
            // try { response.EnsureSuccessStatusCode(); } catch { }
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var doctors = JsonConvert.DeserializeObject<List<Doctor>>(json);
                foreach (var doctor in doctors)
                {
                    Doctors.Add(doctor);
                }
            }
            IsLoading = false; // finally
        }
    }
}
