using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* var data = Enumerable.Range(1, 100);
            Console.WriteLine("the sum is " + data.Sum());
            Console.WriteLine("the average is " + data.Average()); */
            SumAverageRunningInt();
            Console.WriteLine();
            Console.ReadKey();
        }

        static void SumAverageRunningInt()
        {
            double a = 1;
            double b = 100;
            double sum = 0;
            double ave = 0;
            for (double i = a; i <= b; ++i)
            { 
                sum += i;
            }

            ave = sum / (b - a + 1);

            Console.WriteLine($"The sum of 1 to 100 is: {sum}");
            Console.WriteLine($"The average is: {ave}");
        }
    }
}
