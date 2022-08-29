using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Batch1_DET_2022.Animal;

namespace Batch1_DET_2022
{
    internal class ProgramAnimal
    {
        public static void Main()
        {

            List<Animal> Animals = new List<Animal>();
            Animals.Add(new Cat ());
            Animals.Add(new Dog ());
            Animals.Add(new frog ());

            foreach (Animal a in Animals)
                Console.WriteLine(a.ToString());
        }
    }
}
