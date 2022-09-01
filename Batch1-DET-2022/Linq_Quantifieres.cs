using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    public class Linq_Quantifieres
    {


        public static void Main()
        {
            Quantifieres_all();
            Quantifieres_any();
            Quantifieres_contain();
        }


        public static void Quantifieres_all()
        {
            string[] names = { "Bob", "Bed", "Bag", "Bill" ,"Nammu","na"};

            var result = names.All(n => n.StartsWith("B"));

            Console.WriteLine("Does all of the names start with the letter 'B':");
            Console.WriteLine(result);
        }

        public static void Quantifieres_any()
        {
            string[] names = { "Nob", "Ned", "Amy", "Bill" };

             var result = names.All(n => n.StartsWith("B"));

            Console.WriteLine("Does any of the names start with the letter 'B':");
            Console.WriteLine(result);
        }

        public static void Quantifieres_contain()
        {
            int[] numbers = { 1, 3, 5, 7, 9 ,10 ,11 ,20};

            var result = numbers.Contains(6);

            Console.WriteLine("sequence contains the value 6:");
            Console.WriteLine(result);
        }
    }
}

