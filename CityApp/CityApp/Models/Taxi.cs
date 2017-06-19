using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityApp.Models
{
    public class Taxi
    {
        public string Name { get; set; }
        public List<string> PhoneNumbers { get; set; }

        public static List<Taxi> GetFakeTaxiList()
        {
            List<Taxi> taxiList = new List<Taxi>
            {
                new Taxi
                {
                    Name = "Гепард",
                    PhoneNumbers = new List<string>
                    {
                        "+7 (905) 514 36 25",
                        "+7 926 118 84 84"
                    }
                },
                new Taxi
                {
                    Name = "Городское",
                    PhoneNumbers = new List<string>
                    {
                        "+7 (916) 514-36-25",
                        "+7 (916) 331-26-33"
                    }
                },
                new Taxi
                {
                    Name = "Краснознаменская Служба Такси",
                    PhoneNumbers = new List<string>
                    {
                        "+7 (925) 944-93-44",
                        "+7 (915) 229-18-18"
                    }
                },
                new Taxi
                {
                    Name = "Лидер",
                    PhoneNumbers = new List<string>
                    {
                        "+7 (916) 094-66-22",
                        "+7 (926) 300-51-15"
                    }
                },
                new Taxi
                {
                    Name = "Монета",
                    PhoneNumbers = new List<string>
                    {
                        "+7 (925) 110-07-72",
                        "+7 (919) 103-08-88"
                    }
                },
                new Taxi
                {
                    Name = "Русь",
                    PhoneNumbers = new List<string>
                    {
                        "+7 (926) 301-30-11",
                        "+7 (916) 999 11 12",
                        "+7 905 776 14 76"
                    }
                },
                new Taxi
                {
                    Name = "Элита+",
                    PhoneNumbers = new List<string>
                    {
                        "+7 (925) 051-25-80",
                    }
                },
            };
            return taxiList;
        }
    }
}
