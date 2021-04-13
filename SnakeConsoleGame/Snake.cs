using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SnakeConsoleGame
{
    class Snake
    {
        int width = 25;
        int height = 15;

        ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
        char key = 'W';

        int[] X = new int[50];
        int[] Y = new int[50];

        int foodX;
        int foodY;

        int parts = 1;
        Random rand = new Random();

        public Snake(int x, int y)
        {
            X[0] = x;
            Y[0] = y;
            Console.CursorVisible= false;
            foodX = rand.Next(2, width - 2);
            foodY = rand.Next(2, height - 2);
        }
        public void PrintBoard()
        {
            Console.Clear();
            for (int i = 0; i <= width; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write("*");
            }
            for (int i = 1; i < height; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("|");
            }
            for (int i = 1; i < height; i++)
            {
                Console.SetCursorPosition(width, i);
                Console.Write("|");
            }
            for (int i = 0; i <= width; i++)
            {
                Console.SetCursorPosition(i, height);
                Console.Write("*");
            }
        }
        public void Input()
        {
            if (Console.KeyAvailable)
            {
                keyInfo = Console.ReadKey(true);
                key = keyInfo.KeyChar;
            }
        }
        public void WriteSnake(int snakeX, int snakeY)
        {
            Console.SetCursorPosition(snakeX, snakeY);
            Console.Write("#");
        }
        public void WriteFood(int foodX, int foodY)
        {
            Console.SetCursorPosition(foodX, foodY);
            Console.Write("O");
        }
        public void Game()
        {
            if(X[0] == foodX && Y[0] == foodY)
            {
                parts++;
                foodX = rand.Next(2, width - 2);
                foodY = rand.Next(2, height - 2);
            }
            for (int i = parts; i > 1; i--)
            {
                X[i - 1] = X[i - 2];
                Y[i - 1] = Y[i - 2];

            }
            switch (key)
            {
                case 'w':
                    Y[0]--;
                    break;
                case 's':
                    Y[0]++;
                    break;
                case 'a':
                    X[0]--;
                    break;
                case 'd':
                    X[0]++;
                    break;
            }
            for (int i = 0; i <= parts - 1; i++)
            {
                WriteSnake(X[i], Y[i]);
                WriteFood(foodX, foodY);
            }
            Thread.Sleep(100);
        }
    }
}
