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
            
            bool gameOver = false;
            int rolledNumber = 0;
            
            int sum = 0;
            do
            {
                rolledNumber = num.Next(1, 7);
                Console.WriteLine($"You rolled a {rolledNumber}!");
                if (rolledNumber == 1)
                {
                    
                    Console.WriteLine("You got 0 points.");
                    break;
                }
                else
                {
                    sum += rolledNumber;
                    Console.Write("Roll again? ");
                    string input = Console.ReadLine().ToLower();
                    switch (input)
                    {
                        case "y": case "yes":
                            gameOver = false;
                            break;
                        case "n": case "no":
                            gameOver = true;
                            break;
                    }

                    
                }


            } while (!gameOver);
            if (rolledNumber != 1)
            {
                Console.WriteLine($"You got {sum} points.");
                
            }
        }

    }
}

