using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Modules
{
    public class Region
    {

        public string NameRegion { get; set; }

        public List<Service> service = new List<Service>();
    }
}