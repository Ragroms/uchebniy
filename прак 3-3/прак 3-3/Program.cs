using System.Net.NetworkInformation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Intrinsics.Arm;
namespace прак_3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m;
            Console.Write("Вводим номер месяца: ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Время года-месяц: ");
            switch (m)
            {
                case 12:
                    Console.WriteLine("Зима-Декабрь");
                    break;
                case 1:
                    Console.WriteLine("Зима-Январь");
                    break;
                case 2:
                    Console.WriteLine("Зима-Февраль");
                    break;
                case 3:
                    Console.WriteLine("Весна-Март");
                    break;
                case 4:
                    Console.WriteLine("Весна-Апрель");
                    break;
                case 5:
                    Console.WriteLine("Весна-Май");
                    break;
                case 6:
                    Console.WriteLine("Лето-Июнь");
                    break;
                case 7:
                    Console.WriteLine("Лето-Июнь");
                    break;
                case 8:
                    Console.WriteLine("Лето-Август");
                    break;
                case 9:
                    Console.WriteLine("Осень-Сентябрь");
                    break;
                case 10:
                    Console.WriteLine("Осень-Октябрь");
                    break;
                case 11:
                    Console.WriteLine("Осень-Ноябрь");
                    break;
                default:
                    Console.WriteLine("Не существует");
                    break;
            };
            while (Console.ReadKey().Key != ConsoleKey.Escape) ;
        }
    }
}