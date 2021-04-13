using System;

namespace Lab15
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 num = new Class1(320);
            Console.WriteLine(num.getSum());
            Console.WriteLine(num.ZeroCount());
        }
    }
}
