using System;

namespace Lab8_2
{
    class Program
    {
        static double getMax(double a, double b, double c)
        {
            double max = a;
            if (b > max) max = b;
            if (c > max) max = c;
            return max;
        }
        static double getLenOfVector(double[] vector)
        {
            return Math.Pow(Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2), 1 / 2.0);
        }
        static double getAngle(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            double[] vector1 = { x2 - x1, y2 - y1 };
            double[] vector2 = { x4 - x3, y4 - y3 };
            double scalar = vector1[0] * vector2[0] + vector1[1] * vector2[1];
            return Math.Cos(scalar / (getLenOfVector(vector1) * getLenOfVector(vector2)));
        }
        static void getType(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            double angle1 = getAngle(x1, y1, x2, y2, x1, y1, x3, y3);
            double angle2 = getAngle(x3, y3, x1, y1, x3, y3, x2, y2);
            double angle3 = getAngle(x2, y2, x1, y1, x2, y2, x3, y3);
            double maxAngle = getMax(angle1, angle2, angle3);
            if (maxAngle == 1)  Console.WriteLine("Right triangle");
            else if(maxAngle < 1 && maxAngle > 0)  Console.WriteLine("Acute triangle");
            else Console.WriteLine("Obtuse triangle");
        }
        static void Main(string[] args)
        {
            getType(0, 0, 5, 0, 0, 5);
        }
    }
}
