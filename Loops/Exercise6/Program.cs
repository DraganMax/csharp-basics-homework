using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer: ");
            int input = int.Parse(Console.ReadLine());
            FizzBuzz(input);
            
            Console.ReadLine();
        }

        static void FizzBuzz(int number)
        {
            
            int temp = 0;
            for (int i = 1; i <= number; i++)
            {
                if (temp == 20)
                {
                    temp = 0;
                    Console.WriteLine();
                    
                }
                temp++;

                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write("FizzBuzz ");
                    //continue;
                }
                if (i % 3 == 0)
                {
                    Console.Write("Fizz ");
                    //continue;
                }
                else if (i % 5 == 0)
                {
                    Console.Write("Buzz ");
                    //continue;
                }
                else
                {
                    Console.Write(i + " ");
                }
            }
            
        }
    }
}
