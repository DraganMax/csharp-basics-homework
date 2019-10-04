using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog Max = new Dog("Max", "male", "Lady", "Rocky");
            Dog Rocky = new Dog("Rocky", "male", "Molly", "Sam");
            Dog Sparky = new Dog("Sparky", "male");
            Dog Buster = new Dog("Buster", "male");
            Dog Sam = new Dog("Sam", "male");
            Dog Lady = new Dog("Lady", "female");
            Dog Molly = new Dog("Molly", "female");
            Dog Coco = new Dog("Coco", "female", "Molly", "Buster");

            Console.WriteLine(Coco.FathersName());
            Console.WriteLine(Sam.FathersName());
            Console.WriteLine(Sparky.FathersName());
            Console.WriteLine(Rocky.HasSameMotherAs(Coco));
            Console.WriteLine(Rocky.HasSameMotherAs(Molly));
            Console.ReadLine();
        }
    }
}
