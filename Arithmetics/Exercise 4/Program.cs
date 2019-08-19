using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Product1ToN());
            Console.Read();
        }
        static int Product1ToN()
        {
            int a = 1;
            for (int i = 1; i <= 10; ++i)
            {
                a *= i;
            }

            return a;
        }
    }
}
