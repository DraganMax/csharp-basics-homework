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
            Console.WriteLine("+---------------------------------------------+");
            Console.WriteLine(String.Format("|{0,-3} | {1,-20} | {2,16}|", "", "My Courses", "My Teachers"));
            Console.WriteLine("----------------------------------------------|");
            Console.WriteLine(String.Format("|{0,-3} | {1,-20} | {2,16}|", "1", "English III", "Ms.Lapan"));
            Console.WriteLine(String.Format("|{0,-3} | {1,-20} | {2,16}|", "2", "Precalculus", "Mrs.Gideon"));
            Console.WriteLine(String.Format("|{0,-3} | {1,-20} | {2,16}|", "3", "Music Theory", "Ms.Palmer"));
            Console.WriteLine(String.Format("|{0,-3} | {1,-20} | {2,16}|", "4", "Biotechnology", "Mr.Davis"));
            Console.WriteLine(String.Format("|{0,-3} | {1,-20} | {2,16}|", "5", "Technology", "Ms.Garcia"));
            Console.WriteLine(String.Format("|{0,-3} | {1,-20} | {2,16}|", "6", "Latin II", "Mrs.Barnett"));
            Console.WriteLine("+---------------------------------------------+");
            Console.ReadKey();
        }
    }
}
