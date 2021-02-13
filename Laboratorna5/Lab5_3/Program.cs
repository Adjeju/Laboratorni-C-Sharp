using System;

namespace Lab2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x = ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("E = ");
            double E = Convert.ToDouble(Console.ReadLine());

            double static_value = Math.Pow(x, 2) / Math.Pow(Math.PI, 2); 
            double problem = 0;
            double result = x;
            int i = 2;

            while (true)
            {
                problem = 1 - static_value / (Math.Pow((i - 1), 2));
                i += 1;
                if (Math.Abs(problem) < E) break;
                result *= problem;
            }

            Console.WriteLine("Result: {0}",result);
        }
    }
}
