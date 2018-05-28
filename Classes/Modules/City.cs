using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Modules

{
    public class City
    {
        public string CityName { get; set; }

        public List<Region> region = new List<Region>();
    }
}