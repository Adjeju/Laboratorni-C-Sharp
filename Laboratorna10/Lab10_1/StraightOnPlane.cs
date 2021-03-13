using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10_1
{
    class StraightOnPlane
    {
        private int[] koef;
        private int[] dot;

        public int[] Koef
        {
            get { return koef; }
            set { koef = value; }
        }
        public int[] Dot
        {
            get { return dot; }
            set { dot = value; }
        }
        
        public StraightOnPlane(int[] koef, int[] dot)
        {
            Koef = koef;
            Dot = dot;
        }
        public void inputNewData(int[] newKoef, int[] newDot)
        {
            Koef = newKoef;
            Dot = newDot;
        }

        public void printData()
        {
            Console.Write("Dot:");
            for (int i = 0; i < Dot.GetLength(0); i++)
            {
                Console.Write("{0,2}", Dot[i]);
            }
            Console.WriteLine();
            Console.Write("Koef:");
            for (int i = 0; i < Koef.GetLength(0); i++)
            {
                Console.Write("{0,2}", Koef[i]);
            }
        }
        public int[] getIntersection(StraightOnPlane other)
        {
            int a = (Koef[0] * Dot[0] * other.Koef[1] - other.Dot[1] * other.Koef[0] * Koef[0] + Dot[1] * Koef[0] * other.Koef[0] - Dot[0] * Koef[1] * Koef[0]) / (Koef[0] * other.Koef[1] - Koef[1] * other.Koef[1]);
            int b = (a * Koef[1] - Dot[0] * Koef[1] + Dot[2] * Koef[0]) / Koef[0];
            return new int[] { a, b };
        }

        public bool isPararel(StraightOnPlane other)
        {
            return (double)Koef[0] / other.Koef[0] == (double)Koef[1] / other.Koef[1];
        }
        public bool isBelong(int[] otherDot)
        {
            return (otherDot[0] - Dot[0]) / Koef[0] == (otherDot[1] - Dot[1]) / Koef[1];
        }

    }
}
