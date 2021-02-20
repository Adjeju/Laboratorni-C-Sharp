using System;

namespace Lab6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x = ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] arr = new double[n];
            int mn = 1;

            for (int i = 1; i < n + 1; i++)
            {
                double elem = Math.Pow(-1, i + 1) * Math.Sin(i * x) * Math.Cos(mn * i);
                mn += 1;
                arr[i - 1] = elem;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            int minIndex = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < arr[minIndex]) minIndex = i;
            }

            Console.WriteLine(minIndex);
        }
    }
}
