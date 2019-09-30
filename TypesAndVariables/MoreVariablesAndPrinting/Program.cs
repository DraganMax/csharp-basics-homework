﻿using System;

namespace MoreVariablesAndPrinting
{
    class Program
    {
        static void Main(string[] args)
        {


            string name = "Zed A. Shaw";
            int age = 35;
            int height = 74;  // inches
            int weight = 180; // lbs
            string eyes = "Blue";
            string teeth = "White";
            string hair = "Brown";
            double heightInCm = Convert(height, 2.54);
            double weightInKg = Convert(weight, 0.453592);

            Console.WriteLine($"Let's talk about + {name}.");
            Console.WriteLine($"He's {heightInCm} inches tall.");
            Console.WriteLine($"He's {weightInKg} pounds heavy.");
            Console.WriteLine($"Actually, that's not too heavy.");
            Console.WriteLine($"He's got {eyes} eyes and {hair} hair.");
            Console.WriteLine($"His teeth are usually {teeth} depending on the coffee.");

            Console.WriteLine($"If I add {age}, {heightInCm}, and {weightInKg:0.00} I get {age + heightInCm + weightInKg:0.00}.");
            Console.ReadKey();
        }
        static double Convert(double value, double ratio)
        {
            return value * ratio;
        }
    }
}