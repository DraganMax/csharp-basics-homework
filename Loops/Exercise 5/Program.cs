using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two words: ");
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            
            string point = ".";
            string line = "";
            
            int stringLength = input1.Length + input2.Length;
            int pointLength = 30 - stringLength;
            for (int i = 0; i < pointLength; i++)
            {
                line += point;
            } 
            
            Console.Write(input1 + line + input2);
            Console.Read();

        }
    }
}
