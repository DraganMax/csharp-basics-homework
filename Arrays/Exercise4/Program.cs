﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        //TODO: Write a C# program to test if an array contains a specific value.
        private static void Main(string[] args)
        {
            int[] myArray = {
                1789, 2035, 1899, 1456, 2013,
                1458, 2458, 1254, 1469, 2365,
                1456, 2265, 1457, 2456
            };

            
            //fixme - check if contains number 1245 
            //int times = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] == 1254)
                {
                    //times++;
                    Console.WriteLine("myArray contains a number: 1254!");
                }
            }
            //Console.WriteLine($"That number are mentioned {times} times in that array!");

            Console.Read();
        }
    }
}