using System;
using System.Globalization;
using System.Runtime.Remoting.Messaging;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i, n;

            Console.Write("Input number of terms: ");

            int n = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            /*
            todo - complete loop to multiply i with itself n times, it is NOT allowed to use Math.Pow()
            */
            /*for (i = n; i > 1; i--) 
            {
                
            }*/
            Console.Write(Pow(n, b));
            Console.ReadKey();
        }
        static int Pow(int num, int pow)
        {
            int result = num;
            for (int i = 1; i < pow; i++)
            {
                result *= num;
            }

            return result;
        }
        
    }
}
