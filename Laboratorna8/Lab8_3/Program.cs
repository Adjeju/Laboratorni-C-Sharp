using System;

namespace Lab8_3
{
    class Program
    {
        static int getResult(int i)
        {
            if (i == 0) return 0;
            if (i == 1 || i == 2) return 9;
            return getResult(i - 1) + 4 * getResult(i - 3);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(getResult(10));
        }
    }
}
