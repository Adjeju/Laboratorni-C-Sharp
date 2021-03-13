using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11_1
{
    class TArray
    {
        private double[] arrayOfElements;
        private int numOfElements;
        public double[] ArrayOfElements
        {
            get
            {
                return arrayOfElements;
            }
            set
            {
                arrayOfElements = value;
            }
        }
        public int NumOfElements
        {
            get
            {
                return numOfElements;
            }
            set
            {
                numOfElements = value;
            }
        }
        public TArray() { }
        public TArray(int num)
        {
            ArrayOfElements = new double[num];
            NumOfElements = num;
        }
        public void intputData()
        {
            while (true)
            {
                Console.Write("New array: ");
                string[] newArr = Console.ReadLine().Split();
                if (newArr.Length == NumOfElements)
                {
                    for (int i = 0; i < newArr.Length; i++)
                    {
                        ArrayOfElements[i] = Convert.ToDouble(newArr[i]);
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Write array of {0} elements",NumOfElements);
                    continue;
                }
            }

        }
        public void printArray()
        {
            Console.Write("Array: ");
            for (int i = 0; i < ArrayOfElements.Length; i++)
            {
                Console.Write("{0,4}", ArrayOfElements[i]);
            }
            Console.WriteLine();
        }
        public double getMax()
        {
            double maxElem = ArrayOfElements[0];
            for (int i = 0; i < ArrayOfElements.Length; i++)
            {
                if (ArrayOfElements[i] > maxElem) maxElem = ArrayOfElements[i];
            }
            return maxElem;
        }
        public double getMin()
        {
            double minElem = ArrayOfElements[0];
            for (int i = 0; i < ArrayOfElements.Length; i++)
            {
                if (ArrayOfElements[i] < minElem) minElem = ArrayOfElements[i];
            }
            return minElem;
        }
        public void sortArray()
        {
            while (true)
            {
                Console.Write("Enter mode(n/r): ");
                char mode = Convert.ToChar(Console.ReadLine());
                if (mode == 'n')
                {
                    Array.Sort(ArrayOfElements);
                    break;
                }
                else if (mode == 'r')
                {
                    Array.Sort(ArrayOfElements);
                    Array.Reverse(ArrayOfElements);
                    break;
                }
                else
                {
                    Console.WriteLine("Enter n/r : ");
                }
            }
        }
        public double getSumOfArray()
        {
            double sum = 0;
            for (int i = 0; i < ArrayOfElements.Length; i++)
            {
                sum += ArrayOfElements[i];
            }
            return sum;
        }
    }
}
