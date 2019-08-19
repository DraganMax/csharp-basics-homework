using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            CozaLozaWoza();
            Console.ReadLine();
        }

        static void CozaLozaWoza()
        {
            int temp = 0;
            int a = 1;
            int b = 110;
            for (int i = a; i <= b; ++i)
            {
                if (temp == 11)
                {
                    temp = 0;
                    Console.WriteLine();
                }
                temp++;
                
                if (i % 3 == 0 && i % 5 == 0 && i % 7 == 0)
                {
                    Console.Write("CozaLozaWoza ");
                    continue;
                }
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write("CozaLoza ");
                    continue;
                }
                if (i % 3 == 0  && i % 7 == 0)
                {
                    Console.Write("CozaWoza ");
                    continue;
                }
                if (i % 3 == 0)
                {
                    Console.Write("Coza ");
                    continue;
                }
                else if (i % 5 == 0)
                {
                    Console.Write("Loza ");
                    continue;
                }
                else if (i % 7 == 0)
                {
                    Console.Write("Woza ");
                    continue;
                }
                else
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
