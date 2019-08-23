using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random num = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = num.Next(1, 100);
                
                
            }
            
            

            
            int[] copyOfArray = new int[10];
            //Array.Copy(array, copy = new int[array.Length], array.Length);
            for (int i = 0; i < copyOfArray.Length; i++)
            {
                copyOfArray[i] = array[i];
            }

            array[9] = -7;

            Console.WriteLine(string.Join(" ", array));
            Console.WriteLine(string.Join(" ", copyOfArray));
            
            Console.Read();
        }
    }
}
