using System;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            DayTime daytime = new DayTime();
            daytime.PartOfDay();
            daytime.PrintTime();

            Console.ReadLine();
        }
    }
}
