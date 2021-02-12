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

            double problem = 0;
            double result = 0;
            int i = 0;

            while (true)
            {
                problem =(double)(1 - 4 * Math.Pow(x, 2) / (Math.Pow((2 * i - 1), 2) * Math.Pow(Math.PI, 2)));
                result *= problem;
                Console.WriteLine(result);
                Console.WriteLine(problem);
                if (Math.Abs(problem) < E)
                {
                    break;
                }
                i += 1;
            }

            Console.WriteLine("Result: {0}",result);
        }
    }
}
