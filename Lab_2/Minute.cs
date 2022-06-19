using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    class Minute

    {
        private string min;
        public string Min
        { get
            {
                return min;
            }
            set
            {
                if (Convert.ToUInt32(value)>=0 && Convert.ToUInt32(value) < 60)
                {
                    min = value;
                }
                else
                {
                    Console.WriteLine("Введiть значення вiд 0 до 60!");
                }
            }       
        }
        public Minute ()
        {
            Console.WriteLine("Яка зараз хвилина?");
            Min = Console.ReadLine();
        }
    }
}
