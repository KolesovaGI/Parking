using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    class ParkingLot
    {
        int lotNumber; // Номер парковочного места
        int amount; // Количество машин
        public List<Auto> car;

        public void Add(Auto a)
        {
            if (car == null)
            {
                car = new List<Auto>();
            }
            car.Add(a);
        }

        public void Remove(Auto a)
        {
            if (car == null)
            {
                Console.WriteLine("Auto isn't here!");
            }
            car.Remove(a);
        }
        public int LotNumber
        {
            get
            {
                return lotNumber;
            }

            set
            {
                if (value > 0 && value < 110)
                {
                    lotNumber = value;
                }
            }
        }

        public int Amount
        {
            get
            {
                return amount;
            }

            set
            {
                if (value > 0 && value < 110)
                {
                    amount = value;
                }
            }
        }

        public void ShowInfoo()
        {
            foreach (Auto a in car)
            {
                a.ShowInfo();
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine();
            Console.WriteLine($"Номер парковочного места: {lotNumber} ");
            Console.WriteLine($"Количество машин на парковке: {amount} ");
        }
    }
}
