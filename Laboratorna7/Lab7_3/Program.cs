using System;

namespace Lab7_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("m = ");
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] matrixMain = new int[n, m];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrixMain[i, j] = rand.Next(0, 9);
                }
            }
            Console.WriteLine("Main matrix");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0,3}", matrixMain[i, j]);
                }
                Console.WriteLine();
            }
            int[,] matrixT = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrixT[i, j] = matrixMain[j, i];
                }
            }
            Console.WriteLine("Transposed matrix");
            for (int i = 0; i < matrixT.GetLength(0); i++)
            {
                for (int j = 0; j < matrixT.GetLength(1); j++)
                {
                    Console.Write("{0,3}", matrixT[i,j]);
                }
                Console.WriteLine();
            }   
        }
    }
}
