using System;

namespace Lab10_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Monitor monitor = new Monitor("ASUS", 2015, 2021, 10000, "full", new int[] { 1920, 1080 });
            Console.WriteLine("{0} years", monitor.getYear());
            Console.WriteLine($"Koef: {monitor.badScale(new double[] { 2250, 1900 })}");
        }
    }
}
