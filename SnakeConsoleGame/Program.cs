using System;

namespace SnakeConsoleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Snake snake = new Snake(5,5);
            while (true)
            {
                snake.PrintBoard();
                snake.Input();
                snake.Game();
            }
        }
    }
}
