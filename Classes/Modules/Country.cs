using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Modules
{
   public class Country
    {
        public string CountryName { get; set; }

        public List<City> city = new List<City>();
    }

    
}
