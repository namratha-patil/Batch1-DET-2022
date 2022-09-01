﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    public  class LinqTakewhile
    {
        public static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            var result = numbers.TakeWhile(n => n < 8);

            Console.WriteLine("Takes numbers one by one, and stops when condition is no longer met:");
            foreach (int number in result)
                Console.WriteLine(number);
        }
    }
}
