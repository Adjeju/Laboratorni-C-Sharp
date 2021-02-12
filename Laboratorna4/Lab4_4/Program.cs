using System;

namespace Lab1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n= ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (0 <= n && n < 5) Console.WriteLine("y = 0");
            else if (5 <= n && n < 10) Console.WriteLine("y = 1");
            else if (10 <= n && n < 15) Console.WriteLine("y = 2");
            else Console.WriteLine("y = 3");
        }
    }
}
