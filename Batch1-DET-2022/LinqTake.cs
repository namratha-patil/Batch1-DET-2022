using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    public class LinqTake
    {
        public static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 ,11 , 12, 13, 14,
                                15, 16, 17, 18, 19, 20};

            var result = numbers.Take(10);

            Console.WriteLine("Takes the first 10 numbers only:");
            foreach (int number in result)
                Console.WriteLine(number);
        }

    }
}
