using System;
using System.Linq;

namespace Lab7_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = { { -5, 4, 3 }, { 4, 3, 4 }, { 3, 4, 5 } };
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0,3}",matrix[i,j]);
                }
                Console.WriteLine();
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j  = 0; j < 3; j++)
                {
                    if (matrix[j,i] < 0)
                    {
                        int[] cols = new int[3];
                        for (int k = 0; k < 3; k++)
                        {
                            cols[k] = matrix[k, i];
                        }
                        int sum = cols.Sum();
                        if (cols[i] == matrix[j, i])
                        {
                            Console.WriteLine("Sum of {0} col: {1}", i + 1, sum);
                        }
                        break;
                    }
                }
            }
            
        }
    }
}
