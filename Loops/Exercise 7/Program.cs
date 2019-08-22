using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Piglet!");
            PigLet();
            
            Console.Read();
        }

        private static void PigLet()
        {
            Random num = new Random();

            int sum = 0;
            int a = num.Next(1, 6);


                switch (a)
                {
                    case 2:
                        Console.WriteLine("You rolled a " + a + "!");
                        break;
                    case 3:
                        Console.WriteLine("You rolled a " + a + "!");
                        break;
                    case 4:
                        Console.WriteLine("You rolled a " + a + "!");
                        break;
                    case 5:
                        Console.WriteLine("You rolled a " + a + "!");
                        break;
                    case 6:
                        Console.WriteLine("You rolled a " + a + "!");
                        break;
                    default:
                        Console.WriteLine("You rolled" + a + "!");
                        Console.WriteLine("You got 0 points.");
                        break;
                }

                Console.Write("Roll again? ");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "no":
                        sum += a;
                        Console.WriteLine($"You got {sum} points.");
                        break;
                    case "yes":
                        num.Next(1, 6);
                        break;

                }
        }

    }
}

