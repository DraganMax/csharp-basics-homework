using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I'm thinking of number 1-100. Try to guess it!");
            RandomNumber();
           
            Console.Read();
        }

        static void RandomNumber()
        {
            int userNumber = int.Parse(Console.ReadLine());
            Random value = new Random();
            var genNumber = value.Next(1, 100);
            if (userNumber < genNumber)
            {
                Console.WriteLine($"Sorry, you are too low. I was thinking of {genNumber}.");
            }
            else if (userNumber > genNumber)
            {
                Console.WriteLine($"Sorry, you are too high. I was thinking of {genNumber}.");
            }
            else
            {
                Console.WriteLine("You guessed it! What are the odds?!?");
            }



        }

    }
}
