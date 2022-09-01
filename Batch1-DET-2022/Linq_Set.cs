using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    public class Linq_Set
    {

        public static void Main()
        {
            set_Distinct();
            set_Except();
            set_Intersect();
            set_Union();
        }

        public static void set_Distinct()
        {
            int[] numbers = { 1, 4, 7 , 5, 6, 6, 8, 9 , 11 , 1 , 8};

            var result = numbers.Distinct();

            Console.WriteLine("Distinct removes duplicate elements:");
            foreach (int number in result)
            Console.WriteLine(number);
        }

        public static void set_Except()
        {
            int[] numbers1 = { 1, 2, 5};
            int[] numbers2 = { 4, 5 ,3, 6};

            var result = numbers1.Except(numbers2);

            Console.WriteLine("Except creates a single sequence from numbers1 and removes the duplicates found in numbers2:");
            foreach (int number in result)
            Console.WriteLine(number);
        }

        public static void set_Intersect()
        {
            int[] numbers1 = { 1, 2, 3 };
            int[] numbers2 = { 3, 4, 5 };

            var result = numbers1.Intersect(numbers2);

            Console.WriteLine("Intersect creates a single sequence with only the duplicates:");
            foreach (int number in result)
            Console.WriteLine(number);
        }

        public static void set_Union()
        {
            int[] numbers1 = { 1, 2, 3 };
            int[] numbers2 = { 3, 4, 5 };

            var result = numbers1.Union(numbers2);

            Console.WriteLine("Union creates a single sequence and eliminates the duplicates:");
            foreach (int number in result)
            Console.WriteLine(number);
        }
    }
}
