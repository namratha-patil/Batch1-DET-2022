using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Batch1_DET_2022
{
   public class CompanyProgram
    {
    

        public static void Main()
        {
            
            CompanyManager m = new CompanyManager { Name = "Namratha", Surname = "Patil", Phone = "123456789" };
            Company company = new Company { Name = "SSL", Manager = m, Phone = "987654321", website = "Sonata-software.com" };
           
            Console.WriteLine(company.ToString());
           
        }
    }
}
