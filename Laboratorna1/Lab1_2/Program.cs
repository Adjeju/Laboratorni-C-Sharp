using System;

namespace Lab2
{
    class Program
    {
        static double Max(double a, double b)
        {
            if (a > b) return a;
            else return b;
        }
        static double Min(double a, double b)
        {
            if (a > b) return b;
            else return a;
        }
        static void Main(string[] args)
        {
            Console.Write("a= ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b= ");
            double b = Convert.ToDouble(Console.ReadLine());
            double sum = Max(a, b) + Math.Pow(Max(a, b) + Min(a, b), 2);
            Console.WriteLine("Sum= {0}",sum);

        }
    }
}
