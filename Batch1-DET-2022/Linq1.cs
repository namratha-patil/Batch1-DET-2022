using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class Linq1
    {
        public static void Main()

        {
            //The treee Parts of LINQ Query: deffered execution
            //1.Data Source.
            List<int> numbers = new List<int>();
            numbers.Add(110);
            numbers.Add(100);
            numbers.Add(105);
            numbers.Add(102);

            //2. Query Creation. sql type
            //var numQuery = from num in numbers   //select num from numbers
            //               select num;


            //lamda exp
            var numQuery = numbers.Select(x => x);

            //early execution
            //var numQuery = from num in numbers   //select num from numbers
            //               where num > 102
            //                  select num;
          

            //3. Query exection.

            foreach (int num in numQuery)
            {
                Console.Write(" {0} ", num);
                // num.Dump();  //this is for LINQpad not for VS
            }
            Console.ReadLine();

        }
    }
}

