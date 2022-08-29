using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    public class Company
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string website { get; set; }

        public CompanyManager Manager { get; set; }//containment

        override public string ToString()
        {
            return $"Name={Name}, Address={Address}, Phone={Phone}, Website={website}, Manager={Manager.Print()}";
        }
    }
}

