﻿using System;
using System.IO.Ports;

namespace Exercise3
{
    class Program
    {
        //TODO: Write a C# program to calculate the average value of array elements.
        private static void Main(string[] args)
        {
            int[] numbers = {20, 30, 25, 35, -16, 60, -100, 26};

            
            //fixme - calculate sum of all array elements 
            int sum = 0;
            
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
                
            }
            Console.WriteLine($"The sum of elements in array is: {sum}");
            double average = sum / numbers.Length;
            //fixme - calculate average value 
            Console.WriteLine("Average value of the array elements is : " + average);
            Console.Read();
        }
    }
}