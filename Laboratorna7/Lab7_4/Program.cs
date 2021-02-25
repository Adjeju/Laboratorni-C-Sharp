using System;

namespace Lab7_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[n, n];
            Random rand = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = rand.Next(-10, 10);
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,4}",matrix[i,j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("----------------------------------");

            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    int[] col = new int[n];
                    for (int j = 0; j < n; j++)
                    {
                        col[j] = matrix[j,i];
                    }
                    Array.Sort(col);
                    Array.Reverse(col);
                    for (int j = 0; j < n; j++)
                    {
                        matrix[j, i] = col[j];
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,4}", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
