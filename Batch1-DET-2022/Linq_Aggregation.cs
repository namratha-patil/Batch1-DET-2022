using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    public class Linq_Aggregation
    {
        public static void Main()
        {
            //Aggregation_simple();
            //Aggregation_Average();
            // Arrregation_count();
           // Arrregation_min();
           Arrregation_max();
            //Arrregation_sum();

        }
        public static void Aggregation_simple()
        {

            var numbers = new int[] { 1, 2, 3, 4, 5 };

            var result = numbers.Aggregate((a, b) => a * b);

            Console.WriteLine("Aggregated numbers by multiplication:");
            Console.WriteLine(result);
        }
        public static void Aggregation_Average()
        {


            int[] numbers1 = { 10, 10, 11, 11 };

            var result1 = numbers1.Average();

            Console.WriteLine("Average is:");
            Console.WriteLine(result1);
        }
        public static void Arrregation_count()
        {

            string[] names = { "roja", "mary", "pooja", "lilly", "chotu","motu" };

            var result2 = names.Count();

            Console.WriteLine("Counting names gives:");
            Console.WriteLine(result2);
        }

        public static void Arrregation_min()
        {
            int[] numbers = { 6, 9,10,1, 3, 7, 5 };

            var result3 = numbers.Min();

            Console.WriteLine("Lowest number is:");
            Console.WriteLine(result3);
        }

        public static void Arrregation_max()
        {
            int[] numbers = { 2, 8,10,100, 5, 6, 1 };

            var result = numbers.Max();

            Console.WriteLine("Highest number is:");
            Console.WriteLine(result);
        }

        public static void Arrregation_sum()
        {
            int[] numbers = { 2, 5, 10,3 };

            var result = numbers.Sum();

            Console.WriteLine("Summing the numbers yields:");
            Console.WriteLine(result);
        }


    }

}
