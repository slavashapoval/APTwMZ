using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal money, percent;
            int i;
            const byte years = 4;

            money = 5000.0m;
            percent = 0.15m;

            for (i = 1; i <= years; i++)
            {
                money *= 1 + percent;
            }
            Console.WriteLine("Procent = {0}%", percent*100);


            Console.WriteLine("Całkowite przychody za {0} lat: {1} $$", years, money);
            Console.ReadLine();
        }
    }
}
