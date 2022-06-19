using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    class Hour    
    {
        private string hours;
        public string Hours
        {
            get
            {
                return hours;
            }
            set
            {
                if (Convert.ToUInt32(value) >= 0 && Convert.ToUInt32(value) < 24)
                {
                    hours= value;
                }
                else
                {
                    Console.WriteLine("Введіть значення від 0 до 24!");
                }
            }
        }
        public Hour()
        {
            Console.WriteLine("Яка зараз година?");
            Hours = Console.ReadLine();
        }
    }
}

