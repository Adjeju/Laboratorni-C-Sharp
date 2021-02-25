using System;

namespace Lab7_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("m = ");
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[n, m];
            Random rand = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rand.Next(-10, 10);
                }
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0,3}",matrix[i,j]);
                }
                Console.WriteLine();
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] value = new int[m];
                int[] col = new int[m];
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    col[j] = matrix[j, i];
                    if (matrix[j, i] < 0 && matrix[j, i] % 2 == 0) value[j] += matrix[j, i];
                }
                Array.Sort(value,col);
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[j, i] = col[j]; 
                }
            }
            Console.WriteLine("-----------------------------");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0,3}", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
