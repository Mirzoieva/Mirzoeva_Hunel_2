using System;
using System.Collections.Generic;

namespace Lab_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Tariff> tariffs = new List<Tariff>()
            {
                new Tariff("1", 1000, 3000, 300),
                new Tariff("2", 1500, 5000, 500),
                new Tariff("3", 500, 2000, 150)
            };

            Tariff.tariffsHyerarchy(tariffs);
            foreach (var item in tariffs)
            {
                item.NumOfClient();
            }

            Tariff.Sort(tariffs);
            Tariff.InDiapasone(700, 1200, 100, 400, tariffs);

            Console.ReadLine();
        }
    }
}
