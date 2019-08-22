using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number of minutes and you will get that number in days and years:");
            int userInput = int.Parse(Console.ReadLine());
            NumberOfDaysAndYears(userInput);
            Console.Read();
        }

        static void NumberOfDaysAndYears(double minutes)
        {
            var minutesInDays = minutes * 0.000694444;
            var minutesInYears = minutes * 0.000001902587519;
            Console.WriteLine($"This are minutes in days: {minutesInDays:0.00} days.");
            Console.WriteLine($"This are minutes in years: {minutesInYears:0.00} years.");
            

        }
    }
}
