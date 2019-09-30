using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {

            AsciiFigure();
            Console.Read();
        }

        static void AsciiFigure()
        {
            Console.Write("Please set a size of ASCII figure by giving a number: ");
            int size = Convert.ToInt32(Console.ReadLine());
            string slashes = "////";
            string backSlashes = "\\\\\\\\";
            string stars = "****";

            int strLength = size - 1;

            string[] slashArr = new string[strLength];
            string[] backSlashArr = new string[strLength];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < strLength; j++)
                {
                    if (i == 0)
                    {
                        slashArr[j] = slashes;
                        Console.Write(slashArr[j]);
                    }
                    else
                    {
                        slashArr[strLength - i] = stars;
                        Console.Write(slashArr[j]);
                    }
                }

                for (int j = 0; j < strLength; j++)
                {
                    if (i == 0)
                    {
                        backSlashArr[j] = backSlashes;
                        Console.Write(backSlashArr[j]);
                    }
                    else
                    {
                        backSlashArr[i - 1] = stars;
                        Console.Write(backSlashArr[j]);
                    }
                }

                Console.WriteLine();

            }
        }
    }
}
