using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2_2
{
    class Tariff
    {
        string name;
        int traffic;
        int numOfClient;
        int cost;
        public Tariff(string name, int traffic, int numOfClient, int cost)
        {
            this.name = name;
            this.traffic = traffic;
            this.numOfClient = numOfClient;
            this.cost = cost;
        }
        public static void tariffsHyerarchy(List<Tariff> tariffs)
        {
            Console.WriteLine("Iєрархiя тарифiв: ");
            Console.WriteLine("{0,10}   |{1,20}  |{2,20}  |{3,18} ", "Назва", "Трафiк", "Вартiсть", "Кiлькiсть клiєнтiв");
            for (int i = 0; i < tariffs.Count; i++)
            {
                var t = tariffs[i];
                Console.WriteLine("{0,10}   |{1,20}  |{2,20}  |{3,10} ", t.name, t.traffic, t.cost, t.numOfClient);
            }
        }

        public void NumOfClient()
        {
            Console.WriteLine($"Тариф {name} має {numOfClient} клiєнтiв");
        }

        public static void Sort(List<Tariff> arr)
        {
            int len = arr.Count;
            for (int i = 1; i < len; i++)
            {
                for (int j = 0; j < len - i; j++)
                {
                    if (arr[j].traffic > arr[j + 1].traffic)
                    {
                        Tariff temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Вiдсортованi тарифи згiдно об’єму трафiку:");
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine($"{arr[i].name} : {arr[i].traffic}");
            }
        }
        public static void InDiapasone(int min1, int max1, int min2, int max2, List<Tariff> arr)
        {
            Console.WriteLine($"Тариф знаходиться в дiапазонi з {min1} до {max1} за об'ємом трафiку та з {min2} до {max2} за вартiстю абонплати:");
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i].traffic >= min1 && arr[i].traffic <= max1 && arr[i].cost >= min2 && arr[i].cost <= max2)
                {
                    Console.WriteLine($"{arr[i].name}: {arr[i].traffic} - трафiк, {arr[i].cost} - вартiсть");
                }
            }
        }
    }
}
