using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10_2
{
    class Monitor
    {
        private string name;
        private int year;
        private int date;
        private int price;
        private string type;
        private int[] size;

        public string Name{ get; set; }
        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                if (value > 0) year = value;
                else throw new Exception("Error");
            }
        }
        public int Date { get; set; }
        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value > 0) price = value;
                else throw new Exception("Error");
            }
        }
        public string Type { get; set; }
        public int[] Size
        {
            get
            {
                return size;
            }
            set
            {
                if (value.GetLength(0) == 2) size = value;
                else throw new Exception("Error");
            }
        }
        public Monitor(string name, int year, int date, int price, string type, int[] size)
        {
            Name = name;
            Year = year;
            Date = date;
            Price = price;
            Type = type;
            Size = size;
        }

        public int getYear()
        {
            DateTime date = new DateTime(2021, 1, 1);
            return date.Year - Year;
        }

        public bool isImageSized(int[] imageSize)
        {
            return size[0] > imageSize[0] && size[1] > imageSize[1];
        }
        public double badScale(double[] resolution)
        {
            double scaleX = 1;
            double scaleY = 1;
            double koef = 1;
            if (resolution[0] > Size[0]) scaleX = Size[0] / resolution[0];
            if (resolution[1] > Size[1]) scaleX = Size[1] / resolution[1];
            if (scaleX < scaleY) koef = scaleX;
            else if (scaleY < scaleX) koef = scaleY;
            return koef;
        }
    }
}
