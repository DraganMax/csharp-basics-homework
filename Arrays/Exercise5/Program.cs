﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        //TODO: Write a C# program to find the index of an array element.
        private static void Main(string[] args)
        {
            int[] myArray = {25, 14, 56, 15, 36, 56, 77, 18, 29, 49};
            //var indexOfElement36 = Array.IndexOf(myArray, 36);
            //var indexOfElement29 = Array.IndexOf(myArray, 29);

            
            //fixme
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] == 36)
                {
                    Console.WriteLine("Index position of 36 is: " + i);
                }
                else if (myArray[i] == 29)
                {
                    Console.WriteLine("Index position of 29 is: " + i);
                }
            }

            // Console.WriteLine("Index position of 36 is: " + indexOfElement36);
            //Console.WriteLine("Index position of 29 is: " + indexOfElement29);
            Console.Read();

            //Expected output:
            //Index position of 36 is: 4
            //Index position of 29 is: 8

        }
    }
}