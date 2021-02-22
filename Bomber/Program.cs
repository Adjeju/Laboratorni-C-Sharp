using System;

namespace Bomber
{
    class Program
    {
        static void printBoard(string[] board)
        {
            Console.WriteLine("-------------");
            Console.WriteLine("| " + board[1] + " | " + board[2] + " | " + board[3] + " | ");
            Console.WriteLine("-------------");
            Console.WriteLine("| " + board[4] + " | " + board[5] + " | " + board[6] + " | " );
            Console.WriteLine("-------------");
            Console.WriteLine("| " + board[7] + " | " + board[8] + " | " + board[9] + " | ");
            Console.WriteLine("-------------");

        }
        static void Main(string[] args)
        {   
            Console.WriteLine("Welcome to BOMBER");
            bool plaing = true;
            string[] boardExample = new string[10];
            Console.WriteLine("Position numbers of bombs");
            for (int i = 0; i < boardExample.Length; i++)
            {
                boardExample[i] = Convert.ToString(i);
            }
            printBoard(boardExample);
            while (plaing)
            {
                //boards
                string[] board = new string[boardExample.Length];
                for (int i = 0; i < board.Length; i++)
                {
                    board[i] = "X";
                }
                string[] boardCopy = new string[boardExample.Length];
                for (int i = 0; i < board.Length; i++)
                {
                    boardCopy[i] = " ";
                }
                Console.Write("Bomb number: ");
                int bombNumber = Convert.ToInt32(Console.ReadLine());
                printBoard(board);
                //bomb generator
                Random rand = new Random();
                for (int i = 0; i < bombNumber; i++)
                {
                    int randNum = rand.Next(1, 10);
                    if (boardCopy[randNum] == " ") boardCopy[randNum] = "O";
                    else boardCopy[rand.Next(1, 10)] = "O";
                }
                //printBoard(boardCopy);
                int correctCount = 0;
                for (int i = 0; i < bombNumber + 1; i++)
                {
                    Console.Write("Enter a num: ");
                    int attempt = Convert.ToInt32(Console.ReadLine());
                    if (boardCopy[attempt] == "O")
                    {
                        board[attempt] = "O";
                        printBoard(board);
                        correctCount++;
                    }
                    else Console.WriteLine("There isn't any bomb there!");
                    if (correctCount == bombNumber)
                    {
                        Console.WriteLine("You win!");
                    }
                }
                for (int i = 0; i < board.Length; i++)
                {
                    if (boardCopy[i] == "O") board[i] = "O";
                }
                Console.WriteLine("Correct answers: {0}",correctCount);
                Console.WriteLine("Positions, where bobms were:");
                printBoard(board);
                Console.Write("Do you want to continue (t / f): ");
                string continuePlaying = Console.ReadLine();
                if (continuePlaying != "t") plaing = false;
            }
        }
    }
}
