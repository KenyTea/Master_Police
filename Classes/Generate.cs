using Classes.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Generate
    {
        private Random r = new Random();

        
    

        public void GenerContent()
        {
            Country count = new Country();
            count.CountryName = "Kazakhstan";

            for (int i = 0; i < r.Next(1, 5); i++)
            {
                count.city.Add(GenerCity());
            }

          
        }
        public City GenerCity()
        {

            City cities = new City();
            cities.CityName = "City" + (r.Next(1, 1000)).ToString();

            for (int i = 0; i < r.Next(1, 5); i++)
            {
                cities.region.Add(GenerRegions());
            }

            return cities;

        }
        public Region GenerRegions()
        {
            Region reg = new Region();
            reg.NameRegion = "Region" + (r.Next(1, 1000)).ToString();

            for (int i = 0; i < r.Next(1, 5); i++)
            {
                reg.service.Add(GenerSerice());
            }

            return reg;
        }

        public Service GenerSerice()
        {
            Service serv = new Service();
            serv.Name = "Service" + (r.Next(1, 1000)).ToString();
            serv.Code = r.Next(101, 105);
            serv.Address = "Address" + (r.Next(1000, 5000)).ToString();
            serv.Phone = "Phone" + (r.Next(7000000, 8000000)).ToString();
            serv.CountPeolpe = r.Next(1, 30);
            return serv;
        }


        public void PrintNah(Country country)
        {
            foreach (City item in country.city)
            {
                Console.WriteLine(item.CityName);
                //foreach (Region item2 in country.city)
                //{

                //}
            }
        }

    }
}
