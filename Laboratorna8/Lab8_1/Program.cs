using System;

namespace Lab8_1
{
    class Program
    {
        static double GetMax(double a, double b, double c)
        {
            double maxElem = a;
            if (b > a) maxElem = b;
            if (c > b) maxElem = c;
            return maxElem;
        }
        static void Main(string[] args)
        {
            Console.Write("x = ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("y = ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.Write("z = ");
            double z = Convert.ToDouble(Console.ReadLine());
            double maxElem = 0;
            double res = (GetMax(x, y, z) + GetMax(x + y, x * y, 4 * z)) / (GetMax(Math.Pow(GetMax(x + y, x * y, Math.Pow(x, 2)), 2), 7, Math.Pow(z, 2)));
            Console.WriteLine("Result: {0}",res);
        }
    }
}
