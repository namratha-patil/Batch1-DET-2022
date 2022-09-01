using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    public class Element_linq
    {
        public static void Main()
        {
            Element_at();
            Element_At_or_defult();
            Element_FirstSimple();
            Element_FirstCondition();
            Element_Last();

        }


        public static void Element_at()
        {
            string[] words = { "One", "Two", "Three","four", "five"};

            var result = words.ElementAt(2);

            Console.WriteLine("Element at index 2 in the array is:");
            Console.WriteLine(result);
        }

        public static void Element_At_or_defult()
        {
            string[] colors = { "Red", "Green", "Blue" };

            var resultIndex1 = colors.ElementAtOrDefault(1);

            var resultIndex10 = colors.ElementAtOrDefault(10);

            Console.WriteLine("Element at index 1 in the array contains:");
            Console.WriteLine(resultIndex1);

            Console.WriteLine("Element at index 10 in the array does not exist:");
            Console.WriteLine(resultIndex10 == null);
        }

        public static void Element_FirstSimple()
        {
            string[] fruits = { "roja", "mary", "pooja", "lilly", "chotu", "motu" };

            var result = fruits.First();

            Console.WriteLine("First element in the array is:");
            Console.WriteLine(result);
        }

        public static void Element_FirstCondition()
        {
            string[] countries = { "NAMRATHA", "SABHYATA", "SIMRAN" };

            var result = countries.First(c => c.Length == 8);

            Console.WriteLine("First element with a length of 8 characters:");
            Console.WriteLine(result);

        }

        public static void Element_Last()
        {
            int[] numbers = { 7,100, 3, 5,10,1 };

            var result = numbers.Last();

            Console.WriteLine("Last number in array is:");
            Console.WriteLine(result);
        }

    }

}
