using System;

namespace TicTacToe
{
    class Program
    {
        private static char[,] board = new char[3, 3];

        private static void Main(string[] args)
        {
            Console.WriteLine("Game already in progress!");
            Console.WriteLine("'X', choose your location, (row, column): ");

            int input1 = Convert.ToInt32(Console.ReadLine());
            int input2 = Convert.ToInt32(Console.ReadLine());
            board[input1, input2] = 'X';
            DisplayBoard();

            Console.WriteLine("'O', choose your location, (row, column): ");
            int input3 = Convert.ToInt32(Console.ReadLine());
            int input4 = Convert.ToInt32(Console.ReadLine());
            board[input3, input4] = 'O';
            
            //InitBoard();
            DisplayBoard();
            Console.WriteLine("'X', choose your location, (row, column): ");

            int input5 = Convert.ToInt32(Console.ReadLine());
            int input6 = Convert.ToInt32(Console.ReadLine());
            board[input5, input6] = 'X';
            DisplayBoard();

            Console.WriteLine("'O', choose your location, (row, column): ");
            int input7 = Convert.ToInt32(Console.ReadLine());
            int input8 = Convert.ToInt32(Console.ReadLine());
            board[input7, input8] = 'O';
            DisplayBoard();

            Console.WriteLine("'X', choose your location, (row, column): ");
            int input9 = Convert.ToInt32(Console.ReadLine());
            int input10 = Convert.ToInt32(Console.ReadLine());
            board[input9, input10] = 'X';
            DisplayBoard();

            Console.ReadLine();
        }

        private static void InitBoard()
        {
            // fills up the board with blanks
            for (var r = 0; r < 3; r++)
            {
                for (var c = 0; c < 3; c++)
                    board[r, c] = ' ';
            }

            
            /*if (input1 == 0 && input2 == 0)
            {
                board[0, 0] = 'X';
            }
            if (input1 == 0 && input2 == 1)
            {
                board[0, 1] = 'X';
            }
            if(input1 == 0 && input2 == 2)
            {
                board[0, 2] = 'X';
            }
            if(input1 == 1 && input2 == 0)
            {
                board[1, 0] = 'X';
            }
            if (input1 == 1 && input2 == 1)
            {
                board[1, 1] = 'X';
            }
            if (input1 == 1 && input2 == 2)
            {
                board[1, 2] = 'X';
            }
            if (input1 == 2 && input2 == 0)
            {
                board[2, 0] = 'X';
            }
            if (input1 == 2 && input2 == 1)
            {
                board[2, 1] = 'X';
            }
            if (input1 == 2 && input2 == 2)
            {
                board[2, 2] = 'X';
            }

            Console.WriteLine("'O', choose your location, (row, column): ");
            if (input1 == 0 && input2 == 0)
            {
                board[0, 0] = 'O';
            }
            if (input1 == 0 && input2 == 1)
            {
                board[0, 1] = 'O';
            }
            if (input1 == 0 && input2 == 2)
            {
                board[0, 2] = 'O';
            }
            if (input1 == 1 && input2 == 0)
            {
                board[1, 0] = 'O';
            }
            if (input1 == 1 && input2 == 1)
            {
                board[1, 1] = 'O';
            }
            if (input1 == 1 && input2 == 2)
            {
                board[1, 2] = 'O';
            }
            if (input1 == 2 && input2 == 0)
            {
                board[2, 0] = 'O';
            }
            if (input1 == 2 && input2 == 1)
            {
                board[2, 1] = 'O';
            }
            if (input1 == 2 && input2 == 2)
            {
                board[2, 2] = 'O';
            }
            */



        }

        private static void DisplayBoard()
        {
            Console.WriteLine("  0  " + board[0, 0] + "|" + board[0, 1] + "|" + board[0, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  1  " + board[1, 0] + "|" + board[1, 1] + "|" + board[1, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  2  " + board[2, 0] + "|" + board[2, 1] + "|" + board[2, 2]);
            Console.WriteLine("    --+-+--");
        }
    }
}
