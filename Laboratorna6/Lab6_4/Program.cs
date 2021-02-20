using System;

namespace Lab6_4
{
    class Program
    {
        static void Swap(ref int a, ref int b)
        {
            int c = 0;
            c = a;
            a = b;
            b = c;
        }
        static void Main(string[] args)
        {
            Console.Write("Array: ");
            string[] arr = Console.ReadLine().Split();
            int[] arrInt = new int[arr.Length];
            
            for (int i = 0; i < arr.Length; i++)
            {
                arrInt[i] = Convert.ToInt32(arr[i]);
            }

            int max = 0;
            for (int i = 0; i < arrInt.Length; i++)
            {
                if (Math.Abs(arrInt[i]) <= 1)
                {
                    Swap(ref arrInt[i], ref arrInt[max]);
                    max++;
                }
            }

            for (int i = 0; i < arrInt.Length; i++)
            {
                Console.WriteLine(arrInt[i]);
            }
        }
    }
}
