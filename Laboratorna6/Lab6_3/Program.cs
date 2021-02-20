using System;

namespace Lab6_3
{
    class Program
    {
        static int[] getVector()
        {
            Console.Write("Coordinates: ");
            string[] arrString = Console.ReadLine().Split();
            int[] arrInt = new int[arrString.Length];

            for (int i = 0; i < arrString.Length; i++)
            {
                arrInt[i] = Convert.ToInt32(arrString[i]);
            }
            return arrInt;
        }
        static int getScalar(int[] a, int[] b)
        {
            int res = 0;
            for (int i = 0; i < a.Length; i++)
            {
                res += a[i] * b[i];
            }
            return res;
        }
        static void Main(string[] args)
        {
            int[] vector1 = getVector();
            int[] vector2 = getVector();
            int[] vector3 = getVector();
            int sum = 2 * getScalar(vector1, vector2) - 3 * getScalar(vector1, vector3);
            Console.WriteLine("Sum: {0}", sum);
        }
    }

