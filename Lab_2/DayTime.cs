using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    class DayTime
    {
        Hour hour = new Hour();
        Minute minute = new Minute();
        public void PrintTime()
        {
            Console.WriteLine($"Поточний час {hour.Hours}:{minute.Min}");
        }

        public void PartOfDay()
        {
            int check = Convert.ToInt32(hour.Hours);

            if (check >= 6 && check < 12)
            {
                Console.WriteLine("Наразi ранок");
            }
            else if(check>=12 &&check<17)
            {
                Console.WriteLine("Наразi день");
            }
            else if (check >= 17 && check < 23)
            {
                Console.WriteLine("Наразi вечiр");
            }
            else
            {
                Console.WriteLine("Наразi нiч");
            }
        }
    }
}

