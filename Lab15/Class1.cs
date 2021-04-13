using System;
using System.Collections.Generic;
using System.Text;

namespace Lab15
{
    class Class1 : Interface1
    {
        public int number;
        public Class1(int num)
        {
            this.number = num;
        }
        public int getSum()
        {
            int tempNUm = number;
            int sum = 0;
            while (tempNUm != 0)
            {
                int ost = tempNUm % 10;
                sum += ost;
                tempNUm = (tempNUm - ost) / 10;
            }
            return sum;
        }

        public int ZeroCount()
        {
            int tempNUm = number;
            int count = 0;
            while (tempNUm > 0)
            {
                int ost = tempNUm % 10;
                if (ost == 0) count++;
                tempNUm = (tempNUm - ost) / 10;
            }
            return count;
        }
    }
}
