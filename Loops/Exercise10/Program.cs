using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberSquare();
            Console.ReadLine();
        }

        static void NumberSquare()
        {
            Console.Write("Enter a min number: ");
            int min = int.Parse(Console.ReadLine());
            Console.Write("Enter a max number: ");
            int max = int.Parse(Console.ReadLine());
            int i;
            for (i = min; i <= max; i++)
            {
                for (int j = i; j <= max; j++)
                {
                    Console.Write(j);
                }
                for (int k = min; k < i; k++)
                {
                    Console.Write(k);
                }
                Console.WriteLine();
            }

            
            
        }
    }
}
