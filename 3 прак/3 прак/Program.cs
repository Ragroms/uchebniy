using System.Net.NetworkInformation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace _3_прак
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Рязанова Юлия");
            Console.WriteLine();
            int a, b;
            Console.WriteLine("Вводим a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Вводим b: ");
            b = Convert.ToInt32(Console.ReadLine());
            int x;
            if (a > b)
            {
                x = 2 * a + b;
                Console.WriteLine("Вычисляем выражение А: " + x);
                Console.ReadLine();
            }
            else
                if (a < b)
            {

                x = (a - 5) / b;
                Console.WriteLine("Вычисляем выражение Б: " + -x);
                Console.ReadLine();
            }
            else
                if (a == b)
            {
                x = -2;
                Console.WriteLine("Вычисляем выражение В: " + x);
                Console.ReadLine();
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape) ;
        }
    }
}