using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your weight: ");
            var a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter your height: ");
            var b = Convert.ToDouble(Console.ReadLine());
            PersonWeight(a, b);
            Console.ReadKey();
        }
        static double PersonWeight(double weight, double height)
        {
            double weightInPounds = weight * 2.205;
            double heightInInches = height / 2.54;
            double BMI = Math.Round(weightInPounds * 703 / Math.Pow(heightInInches, 2));
            if (BMI < 18.5)
            {
                Console.WriteLine($"Your BMI index is: {BMI}, that's not good, you are considered as underweight!");
            }
            if (BMI >= 18.5 && BMI <= 25)
            {
                Console.WriteLine($"Your BMI index is: {BMI}, that's good!");
            }

            if (BMI > 25)
            {
                Console.WriteLine($"Your BMI index is: {BMI}, that's not good, you are considered as overweight!");
            }
            return BMI;
        }
    }
}

