using System;
using System.Linq;

namespace Lab6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter vector's coordinates: ");
            double[] vector = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double res = 1;
            foreach (var i in vector)
            {
                if (i < 0) res *= i;
            }
            Console.WriteLine("Result: {0}",res);
        }
    }
}
