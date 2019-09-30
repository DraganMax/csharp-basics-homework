using System;

namespace Exercise1
{
    class Program
    {
        //TODO: Write a C# program to sort a numeric array and a string array.
        private static void Main(string[] args)
        {
            int[] myArray1 =
            {
                1789, 2035, 1899, 1456, 2013,
                1458, 2458, 1254, 1472, 2365,
                1456, 2165, 1457, 2456
            };
            Console.Write("Original numeric array : "); //Sort array
            for (int i = 0; i < myArray1.Length; i++)
            {
                Console.Write(string.Join(", ", myArray1[i] + " "));
            }
            Console.WriteLine();
            Console.Write("Sorted numeric array : ");
            Array.Sort(myArray1);
            for (int i = 0; i < myArray1.Length; i++)
            {
                Console.Write(myArray1[i] + " ");
            }
            Console.WriteLine();

            string[] myArray2 =
            {
                "Java",
                "Python",
                "PHP",
                "C#",
                "C Programming",
                "C++"
            };

            Console.Write("Original string array : ");
            for (int i = 0; i < myArray2.Length; i++)
            {
                Console.Write(string.Join(", ", myArray2[i] + ", "));
            }
            //fixme
            Console.WriteLine();
           
            Array.Sort(myArray2);
            Console.Write("Sorted string array : ");
            for (int i = 0; i < myArray2.Length; i++)
            {
                Console.Write(myArray2[i] + ", ");
            }
            Console.ReadKey();
        }

    }
}
