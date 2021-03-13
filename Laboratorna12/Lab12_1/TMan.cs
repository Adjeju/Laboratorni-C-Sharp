using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12_1
{
    class TMan
    {
        private string nameOfPersone;
        private int age;
        private char sex;

        public string NameOfPersone
        {
            get
            {
                return nameOfPersone;
            }
            set
            {
                value = nameOfPersone;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value > 0) age = value;
                else throw new Exception("Error");
            }
        }
        public char Sex
        {
            get
            {
                return sex;
            }
            set
            {
                if (value == 'm' || value == 'f') sex = value;
                else throw new Exception("Error");
            }
        }
        public TMan(string name, int age, char sex)
        {
            NameOfPersone = name;
            Age = age;
            Sex = sex;
        }
        public void getGoroskop(int month)
        {
            switch (month)
            {
                case 1:
                    Console.WriteLine("Kozerog"); ;
                    break;
                case 2:
                    Console.WriteLine("Vodolej"); ;
                    break;
                case 3:
                    Console.WriteLine("Ribi"); ;
                    break;
                case 4:
                    Console.WriteLine("Oven"); ;
                    break;
                case 5:
                    Console.WriteLine("Telec"); ;
                    break;
                case 6:
                    Console.WriteLine("Blizneci"); ;
                    break;
                case 7:
                    Console.WriteLine("Rak"); ;
                    break;
                case 8:
                    Console.WriteLine("Lev"); ;
                    break;
                case 9:
                    Console.WriteLine("Deva"); ;
                    break;
                case 10:
                    Console.WriteLine("Vesi"); ;
                    break;
                case 11:
                    Console.WriteLine("Skorpion"); ;
                    break;
                case 12:
                    Console.WriteLine("Strelec"); ;
                    break;
                default:
                    break;
            }
        }
        public void getAgeStatus()
        {
            if (Age > 0 && Age <= 18) Console.WriteLine("Baby");
            else if (Age > 18 && Age <= 35) Console.WriteLine("Young");
            else Console.WriteLine("Old");
        }
    }
    
}
