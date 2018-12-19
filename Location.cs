using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailoNailo
{
    class Location
    {
        private string locName;
        private string link;
       

        public Location()
        {
        }

        public Location(string locName, string link)
        {
            this.locName = locName;
            this.link = link;
        }

        public string LocName { get => locName; set => locName = value; }
        public string Link { get => link; set => link = value; }
        
        
    }
}
