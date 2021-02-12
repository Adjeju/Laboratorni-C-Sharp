using System;

namespace Lab3
{
    class Program
    {
        static double GetLenght(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        }
        static void Main(string[] args)
        {
            Console.Write("x1= ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y1= ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("x2= ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y2= ");
            double y2 = Convert.ToDouble(Console.ReadLine());
            double a = GetLenght(x1, y1, x2, y2);
            Console.WriteLine(a);
            Console.Write("x3= ");
            double x3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y3= ");
            double y3 = Convert.ToDouble(Console.ReadLine());

            double AB = GetLenght(x1, y1, x2, y2);
            double BC = GetLenght(x2, y2, x3, y3);
            double AC = GetLenght(x1, y1, x3, y3);

            double maxSide = AB;
            if (BC > maxSide) maxSide = BC;
            else if (AC > maxSide) maxSide = AC;

            Console.WriteLine("Max side: {0}", maxSide);
        }
    }
}
