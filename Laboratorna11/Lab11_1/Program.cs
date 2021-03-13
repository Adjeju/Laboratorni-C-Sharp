using System;

namespace Lab11_1
{
    class Program
    {
        static void Main(string[] args)
        {
            TArray arr = new TArray(5);
            arr.intputData();
            arr.printArray();
            Console.WriteLine($"Max: {arr.getMax()} Min: {arr.getMin()}");
            arr.sortArray();
            Console.Write("Sorted array:");
            for (int i = 0; i < arr.NumOfElements; i++)
            {
                Console.Write("{0,4}", arr.ArrayOfElements[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Sum: {0}", arr.getSumOfArray());
        }
    }
}
