using System;

namespace Lab10_1
{
    class Program
    {
        static void Main(string[] args)
        {
            StraightOnPlane straight = new StraightOnPlane(new int[] { 1, 2 }, new int[] { 3, 7 });
            StraightOnPlane straight2 = new StraightOnPlane(new int[] { 2, 4 }, new int[] { 2, 9 });
            bool test = straight.isPararel(straight2);
            Console.WriteLine(test);
            Console.WriteLine(straight.isBelong(new int[] { 0, 6 }));
        }
    }
}
