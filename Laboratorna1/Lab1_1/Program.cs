using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter lenght of side: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter angle: ");
            double angle = Convert.ToDouble(Console.ReadLine());
            double S = Math.Pow(a, 2.0) * Math.Sin(angle);
            Console.WriteLine("Square: {0}", S);

        }
    }
}
