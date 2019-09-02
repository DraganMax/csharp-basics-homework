using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] words = new string[10]
            {
                "elephant",
                "soccer",
                "waterfall",
                "building",
                "hockey",
                "science",
                "foundation",
                "programming",
                "information",
                "table"
            };
            Random rand = new Random();
            int index = rand.Next(0, words.Length);

            string wordToGuess = words[index];
            
            bool win = false;

            List<char> correctGuessed = new List<char>();
            List<char> incorrectGuessed = new List<char>();

            StringBuilder hiddenWord = new StringBuilder(wordToGuess.Length);
            for (int i = 0; i < wordToGuess.Length; i++)
                hiddenWord.Append('_');

            char guess = ' ';
            string misses = "";

            int lives = 5;
            int letterReaveled = 0;

            while (!win && lives > 0)
            {
                Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-");
                Console.WriteLine($"Word: {hiddenWord}");
                Console.WriteLine($"Misses: {misses}");
                Console.Write("Guess: ");

                try
                {
                    guess = char.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter a single symbol char!");
                }
                
                if (correctGuessed.Contains(guess))
                {
                    Console.WriteLine($"You've already tried {guess} and it was correct.");
                    continue;
                }
                else if (incorrectGuessed.Contains(guess))
                {
                    Console.WriteLine($"Your guess {guess} is wrong!");
                    continue;
                }

                if (wordToGuess.Contains(guess))
                {
                    correctGuessed.Add(guess);

                    for (int i = 0; i < wordToGuess.Length; i++)
                    {
                        if (wordToGuess[i] == guess)
                        {
                            hiddenWord[i] = wordToGuess[i];
                            letterReaveled++;
                        }
                    }

                    if (letterReaveled == wordToGuess.Length)
                        win = true;
                }
                else
                {
                    incorrectGuessed.Add(guess);
                    misses += guess;
                    lives--;
                }
                
                Console.WriteLine(hiddenWord.ToString());
            }
            if (win)
                Console.WriteLine("You won!");
            else
                Console.WriteLine("You lost! It was '{0}'", wordToGuess);

            Console.Write("Press ENTER to exit...");
            Console.ReadLine();
            Console.Read();
        }
    }
}
