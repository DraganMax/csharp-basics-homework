using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double Employee1 = EmployeePaid(7.50, 35);
            double Employee2 = EmployeePaid(8.20, 47);
            double Employee3 = EmployeePaid(10.00, 73);
            Console.Read();
        }

        static double EmployeePaid(double pay, double hours)
        {
            int normalHour = 40;
            if (pay < 8.00)
            {
                Console.WriteLine("Error, your base pay is less than 8.00$.");
            }

            else if (hours > 60)
            {
                Console.WriteLine("Error, your work hours are greater than 60h.");
            }
            else if (hours <= 40)
            {
                double salary = pay * hours;
                Console.WriteLine($"You got: {salary}$");
            }
            else if (hours > 40)
            {
                double salary = (normalHour * pay) + ((hours - normalHour) * (pay * 1.5));
                Console.WriteLine($"You got: {salary}$");
            }

            return 0;
        }   
    }
}
