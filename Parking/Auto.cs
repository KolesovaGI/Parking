using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    class Auto
    {
        string brand; //имя
        string model; //фамилия
        int number; //возраст
        int time; //курс

        public string Brand
        {
            get
            {
                return brand;
            }

            set
            {
                if (value != null)
                {
                    brand = value;
                }
            }
        }

        public string Model
        {
            get
            {
                return model;
            }

            set
            {
                if (value != null)
                {
                    model = value;
                }
                else
                    Console.WriteLine("Model is already exist!");
            }
        }

        public int Number
        {
            get
            {
                return number;
            }

            set
            {
                if (value > 0 && value < 110)
                {
                    number = value;
                }
            }
        }

        public int Time
        {
            get
            {
                return time;
            }

            set
            {
                if (value > 0 && value < 110)
                {
                    time = value;
                }
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine();
            Console.WriteLine($"Марка: {brand} ");
            Console.WriteLine($"Модель: {model} ");
            Console.WriteLine($"Номер: {number} ");
            Console.WriteLine($"Время прибытия: {time} ");
        }

    }
}