using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number!");
            int input = int.Parse(Console.ReadLine());
            
            CheckOddEven(input);
            Console.WriteLine("Bye!");
            Console.ReadKey();
        }

        static int CheckOddEven(int number)
        {
            
            if (number % 2 == 0)
            {
                Console.WriteLine("Even Number!");
            }
            else
            {
                Console.WriteLine("Odd Number!");
            }
            return 0;
        }

    }
}

