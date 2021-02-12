using System;

namespace Lab2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x0 = 1;
            int x1 = 7;
            int x2 = 7;
            int x3 = 7;

            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int res = 0;
            for (int i = 4; i < n + 1; i++)
            {
                res = (x3 * (1 + x2) + x1) / x0;
                x0 = x1;
                x1 = x2;
                x2 = x3;
                x3 = res;
            }
            Console.WriteLine("x(n) = {0}",res);
        }
    }
}
