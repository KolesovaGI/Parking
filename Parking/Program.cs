using System;
using System.Collections.Generic;

namespace Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ParkingLot> parkingLot = new List<ParkingLot>();
            int num = 0;
            int k = 1;

            do
            {
                Console.WriteLine();
                Console.WriteLine("1. Добавить парковку.");
                Console.WriteLine("2. Информация о заполненности.");
                Console.WriteLine("3. Удалить парковку.");
                Console.WriteLine("4. Добавить автомобиль на стоянку.");
                Console.WriteLine("5. Информация о автомобилях на стоянке.");
                Console.WriteLine("6. Поиск машины по модели.");
                Console.WriteLine("7. Выход.");
                Console.Write("Введите пункт: ");

                if (!Int32.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("Ошибка! Введите операцию заново.");
                }
                Console.WriteLine();

                switch (num)
                {
                    case 1:
                        ParkingLot pl = new ParkingLot();
                        pl.LotNumber = k;
                        Console.WriteLine("Номер парковочного места: " + k);
                        parkingLot.Add(pl);

                        break;
                    case 2:
                        Console.Write("Введите номер парковочного места: ");
                        int numb;
                        if (!Int32.TryParse(Console.ReadLine(), out numb))
                        {
                            Console.WriteLine("Ошибка! Введите число заново.");
                        }
                        Console.WriteLine();
                        foreach (var p in parkingLot)
                        {
                            if (p.LotNumber == numb)
                            {
                                Console.WriteLine("Информация о группе" + numb + ":");
                                p.ShowInfo();
                                Console.WriteLine();
                            }
                        }

                        break;
                    case 3:
                        Console.Write("Введите номер парковочного места: ");
                        int a;
                        if (!Int32.TryParse(Console.ReadLine(), out a))
                        {
                            Console.WriteLine("Ошибка! Введите число заново.");
                        }
                        Console.WriteLine();
                        for (int i = 0; i < parkingLot.Count; i++)
                        {
                            if (parkingLot[i].LotNumber == a)
                            {
                                parkingLot.RemoveAt(i);
                                break;
                            }
                        }
                        Console.WriteLine("Группа удалена");
                        break;
                    case 4:
                        Auto cars = new Auto();
                        Console.Write("Введите номер парковочного места: ");
                        int number;
                        if (!Int32.TryParse(Console.ReadLine(), out number))
                        {
                            Console.WriteLine("Ошибка! Введите число заново.");
                        }
                        Console.WriteLine();
                        foreach (var c in parkingLot)
                        {
                            if (c.LotNumber == number)
                            {
                                Console.Write("Введите марку: ");
                                cars.Brand = Console.ReadLine();
                                Console.Write("Введите модель: ");
                                cars.Model = Console.ReadLine();
                                Console.Write("Введите номер: ");
                                cars.Number = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Введите время прибытия: ");
                                cars.Time = Convert.ToInt32(Console.ReadLine());
                                c.Add(cars);
                                c.Amount++;
                            }
                        }
                        break;
                    case 5:
                        Console.Write("Введите номер стоянки: ");
                        int b;
                        if (!Int32.TryParse(Console.ReadLine(), out b))
                        {
                            Console.WriteLine("Ошибка! Введите число заново.");
                        }
                        Console.WriteLine();
                        foreach (var c in parkingLot)
                        {
                            if (c.LotNumber == b)
                            {
                                Console.WriteLine("Информация о автомобилях:");
                                c.ShowInfoo();
                                Console.WriteLine();
                            }
                        }
                        break;
                    case 6:
                        Console.Write("Для вызова, введите модель автомобиля: ");
                        string mod;
                        mod = Console.ReadLine();

                        foreach (var с in parkingLot)
                        {
                            foreach (var s in с.car)
                            {
                                if ((s.Model).Contains(mod))
                                {
                                    s.ShowInfo();
                                }
                            }

                        }
                        break;
                }
                k++;
            } while (num != 7);
        }
    }
}
