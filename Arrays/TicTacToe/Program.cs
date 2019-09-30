using System;

namespace TicTacToe
{
    class Program
    {
        private static string[,] arr = new string[3, 3];

        private static void Main(string[] args)
        {
            int temp = 0;
            bool isOk = false;
            bool isGameOver = false;
            InitBoard();
            do
            {
                do
                {
                    if (isGameOver)
                        break;
                    if (temp == 9)
                    {
                        Console.WriteLine("There is no winner");
                        isGameOver = true;
                        break;
                    }
                    else if ((arr[0, 0] == arr[0, 1] && arr[0, 1] == arr[0, 2]) && arr[0, 0] != " ")
                    {
                        Console.WriteLine("The winner is " + arr[0, 0]);
                        isGameOver = true;
                        break;
                    }
                    else if ((arr[1, 0] == arr[1, 1] && arr[1, 1] == arr[1, 2]) && arr[1, 0] != " ")
                    {
                        Console.WriteLine("The winner is " + arr[1, 0]);
                        isGameOver = true;
                        break;
                    }
                    else if ((arr[2, 0] == arr[2, 1] && arr[2, 1] == arr[2, 2]) && arr[2, 0] != " ")
                    {
                        Console.WriteLine("The winner is " + arr[2, 0]);
                        isGameOver = true;
                        break;
                    }
                    else if ((arr[0, 0] == arr[1, 0] && arr[1, 0] == arr[2, 0]) && arr[0, 0] != " ")
                    {
                        Console.WriteLine("The winner is " + arr[0, 0]);
                        isGameOver = true;
                        break;
                    }
                    else if ((arr[0, 1] == arr[1, 1] && arr[1, 1] == arr[2, 1]) && arr[0, 1] != " ")
                    {
                        Console.WriteLine("The winner is " + arr[0, 1]);
                        isGameOver = true;
                        break;
                    }
                    else if ((arr[0, 2] == arr[1, 2] && arr[1, 2] == arr[2, 2]) && arr[0, 2] != " ")
                    {
                        Console.WriteLine("The winner is " + arr[0, 2]);
                        isGameOver = true;
                        break;
                    }
                    else if ((arr[0, 0] == arr[1, 1] && arr[1, 1] == arr[2, 2]) && arr[0, 0] != " ")
                    {
                        Console.WriteLine("The winner is " + arr[0, 0]);
                        isGameOver = true;
                        break;
                    }
                    else if ((arr[0, 2] == arr[1, 1] && arr[1, 1] == arr[2, 0]) && arr[0, 2] != " ")
                    {
                        Console.WriteLine("The winner is " + arr[0, 2]);
                        isGameOver = true;
                        break;
                    }
                    isOk = false;
                    Console.Write("'X' choose your location (row, column) -> ");
                    string input = Console.ReadLine();
                    input = input.Replace(" ", "");
                    if (input.Length != 2)
                    {
                        Console.WriteLine("Incorrect input! Try again...");
                        continue;
                    }
                    int x = (int)Char.GetNumericValue(input[0]);
                    int y = (int)Char.GetNumericValue(input[1]);
                    if ((x != 0 && x != 1 && x != 2) || (y != 0 && y != 1 && y != 2))
                    {
                        Console.WriteLine("Incorrect input! Try again...");
                        continue;
                    }
                    string player = "X";
                    if (arr[x, y] == " ")
                    {
                        Change(arr, player, x, y);
                        DisplayBoard();
                        temp++;
                        isOk = true;
                    }
                    else
                    {
                        Console.WriteLine("Something goes wrong! Try again...");
                        continue;
                    }
                }
                while (isOk != true);


                do
                {
                    if (isGameOver)
                        break;
                    if (temp == 9)
                    {
                        Console.WriteLine("There is no winner");
                        isGameOver = true;
                        break;
                    }
                    else if ((arr[0, 0] == arr[0, 1] && arr[0, 1] == arr[0, 2]) && arr[0, 0] != " ")
                    {
                        Console.WriteLine("The winner is " + arr[0, 0]);
                        isGameOver = true;
                        break;
                    }
                    else if ((arr[1, 0] == arr[1, 1] && arr[1, 1] == arr[1, 2]) && arr[1, 0] != " ")
                    {
                        Console.WriteLine("The winner is " + arr[1, 0]);
                        isGameOver = true;
                        break;
                    }
                    else if ((arr[2, 0] == arr[2, 1] && arr[2, 1] == arr[2, 2]) && arr[2, 0] != " ")
                    {
                        Console.WriteLine("The winner is " + arr[2, 0]);
                        isGameOver = true;
                        break;
                    }
                    else if ((arr[0, 0] == arr[1, 0] && arr[1, 0] == arr[2, 0]) && arr[0, 0] != " ")
                    {
                        Console.WriteLine("The winner is " + arr[0, 0]);
                        isGameOver = true;
                        break;
                    }
                    else if ((arr[0, 1] == arr[1, 1] && arr[1, 1] == arr[2, 1]) && arr[0, 1] != " ")
                    {
                        Console.WriteLine("The winner is " + arr[0, 1]);
                        isGameOver = true;
                        break;
                    }
                    else if ((arr[0, 2] == arr[1, 2] && arr[1, 2] == arr[2, 2]) && arr[0, 2] != " ")
                    {
                        Console.WriteLine("The winner is " + arr[0, 2]);
                        isGameOver = true;
                        break;
                    }
                    else if ((arr[0, 0] == arr[1, 1] && arr[1, 1] == arr[2, 2]) && arr[0, 0] != " ")
                    {
                        Console.WriteLine("The winner is " + arr[0, 0]);
                        isGameOver = true;
                        break;
                    }
                    else if ((arr[0, 2] == arr[1, 1] && arr[1, 1] == arr[2, 0]) && arr[0, 2] != " ")
                    {
                        Console.WriteLine("The winner is " + arr[0, 2]);
                        isGameOver = true;
                        break;
                    }
                    isOk = false;
                    Console.Write("'O' choose your location (row, column) -> ");
                    string input = Console.ReadLine();
                    input = input.Replace(" ", "");
                    if (input.Length != 2)
                    {
                        Console.WriteLine("Incorrect input! Try again...");
                        continue;
                    }
                    int x = (int)Char.GetNumericValue(input[0]);
                    int y = (int)Char.GetNumericValue(input[1]);
                    if ((x != 0 && x != 1 && x != 2) || (y != 0 && y != 1 && y != 2))
                    {
                        Console.WriteLine("Incorrect input! Try again...");
                        continue;
                    }
                    string player = "O";
                    if (arr[x, y] == " ")
                    {
                        Change(arr, player, x, y);
                        DisplayBoard();
                        temp++;
                        isOk = true;
                    }
                    else
                    {
                        Console.WriteLine("Something goes wrong! Try again...");
                        continue;
                    }
                    if (temp == 3)
                        isGameOver = true;
                }
                while (isOk != true);
            }
            while (isGameOver != true);
        }

        private static void Change(string[,] arr, string player, int x, int y)
        {
            arr[x, y] = player;
        }
        private static void InitBoard()
        {
            // fills up the board with blanks
            for (var r = 0; r < 3; r++)
            {
                for (var c = 0; c < 3; c++)
                    arr[r, c] = " ";
            }
        }

        private static void DisplayBoard()
        {
            Console.WriteLine("  0  " + arr[0, 0] + "|" + arr[0, 1] + "|" + arr[0, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  1  " + arr[1, 0] + "|" + arr[1, 1] + "|" + arr[1, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  2  " + arr[2, 0] + "|" + arr[2, 1] + "|" + arr[2, 2]);
            Console.WriteLine("    --+-+--");
        }
    }
}
