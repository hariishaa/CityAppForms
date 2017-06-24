using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityApp.Models
{
    public class Organization
    {
        public string Category { get; set; }
        public string SubCategory { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        // todo: add other properties

        public static List<Organization> GetFakeOrganizations()
        {
            return new List<Organization>
            {
                new Organization
                {
                    Category = "Финансы",
                    Name = "ВТБ 24, банкомат",
                    Address = "Россия, Московская область, Краснознаменск, улица Генерала Шлыкова, 1",
                },
            };
        }

        public static List<string> GetFakeCategories()
        {
            return new List<string>
            {
                "Авто",
                "Дети",
                "Еда",
                "Животные",
                "Красота",
                "Компьютеры, интернет, телеком",
                "Магазины, рынки, ТЦ",
                "Медицина и здоровье",
                "Образование",
                "Религия",
                "Спорт и оздоровление",
                "Строительство и ремонт",
                "Транспорт",
                "Туризм",
                "Финансы",
                "Другое"
            };
        }
    }
}
