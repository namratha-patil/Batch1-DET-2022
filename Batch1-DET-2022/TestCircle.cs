using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class TestCircle
    {
        public static void Main()
        {
            Circle e = new Circle(45);
            Console.WriteLine($"The area of circle1 = {e.AreaOfCircle()}");
        }
    }
}
