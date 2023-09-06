using System.Net.NetworkInformation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
namespace _5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double g = 100; //гектары
            double c = 20; //центнеры ячменя с гектара
            int y = 1; //года

            do
            {
                g = g * 1.05;
                c = c * 1.02;
                y++;
            }
            while (g * c <= 800);
            Console.WriteLine("Год, в котором урожай превысил 800ц: " + y);

            while (Console.ReadKey().Key != ConsoleKey.Escape) ;
        }
    }
}