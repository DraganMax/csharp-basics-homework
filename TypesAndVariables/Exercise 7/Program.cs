using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string: ");
            Uppercase();
            Console.Read(); 
        }

        private static void Uppercase()
        {
            string text = Console.ReadLine();
            int count = 0;
            foreach (char a in text)
            {
                if (char.IsUpper(a))
                {
                    count++;
                }
            }
            Console.WriteLine(count);

        }
    }
}
