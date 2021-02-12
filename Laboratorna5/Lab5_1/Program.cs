using System;

namespace Lab2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x = ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            double res = 0;
            for (int i = 1; i < n + 1; i++)
            {
                res += Math.Pow(Math.Sin(x), i);
            }
            Console.WriteLine("Result: {0}", res);
        }
    }
}
