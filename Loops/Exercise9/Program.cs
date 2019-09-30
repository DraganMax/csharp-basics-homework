using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a desired sum of two dice: ");
            RollTwoDice();
            Console.ReadLine();
        }

        public static void RollTwoDice()
        {
            
            bool win = false;
            int desiredSum = int.Parse(Console.ReadLine());
            Console.WriteLine($"Desired sum: {desiredSum}");
            Random num = new Random();

            while (!win)
            {
                int generatedNumber1 = num.Next(1, 7);
                int generatedNumber2 = num.Next(1, 7);
                int sum = generatedNumber1 + generatedNumber2;
                Console.WriteLine($"{generatedNumber1} and {generatedNumber2} = {sum}");
                if (sum == desiredSum)
                {
                    win = true;
                }
            }

        }

    }
}
