using System;

namespace Lab12_1
{
    class Program
    {
        static void Main(string[] args)
        {
            TMan persone = new TMan("Andrey", 17, 'm');
            persone.getGoroskop(1);
            persone.getAgeStatus();
        }
    }
}
