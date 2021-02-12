using System;

namespace Lab2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("number = ");
            int number = Convert.ToInt32(Console.ReadLine());
            int numCopy = number;
            int result = 0;
            int lenghtOfNum = 0;
            int sumOfDigits = 0;

            while (number >= 1)
            {
                int ost = number % 10;
                number = number / 10;
                sumOfDigits += ost;
                lenghtOfNum += 1;
            }

            int avarage = sumOfDigits / lenghtOfNum;
            int counter = 0;

            while (numCopy >= 1)
            {
                int ost = numCopy % 10;
                numCopy = numCopy / 10;
                if (ost < avarage){
                    counter += 1;
                }
            }   
            Console.WriteLine("Counter: {0}", counter);
        }
    }
}
