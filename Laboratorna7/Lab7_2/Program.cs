using System;

namespace Lab7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            double[,] arr = new double[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = Math.Sin((Math.Pow(i+1, 2) - Math.Pow(j+1, 2)) / n);
                }
            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write("{0,3}",arr[i,j]);
                }
                Console.WriteLine();
            }
            double[] maxElem = { 0, 0, 0 };
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (Math.Abs(arr[i,j]) > maxElem[0])
                    {
                        maxElem[0] = arr[i, j];
                        maxElem[1] = i;
                        maxElem[2] = j;
                    }
                }
            }
            Console.WriteLine("Max elem: {0}[{1},{2}]",maxElem[0], maxElem[1], maxElem[2]);
        }
    }
}
