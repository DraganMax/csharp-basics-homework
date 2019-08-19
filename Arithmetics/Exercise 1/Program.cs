using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            Console.WriteLine("Numbers are: " + a + ", " + b);
            Console.WriteLine(CheckNumbers(a, b));
            Console.ReadKey();

        }
        static bool CheckNumbers(int a, int b)
            {
               /*if (a == 15 || b == 15)
            {
                return true;
            }
               if (a + b == 15 || a - b == 15)
            {
                return true;
            }
               else
            {
                return false;
            }
            */
            return a == 15 || b == 15 || a + b == 15 || a - b == 15;
            }
        }
 }

