using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace прак_12
{    
    class Matrix
    {
        public int[,] a = new int[5, 5];
        public int x;
        public int n;
        public void One()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"[{i},{j}]: ");
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }                    
            }
        }
        public void Two()
        {
            x = 0; n = int.MaxValue;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"{a[i, j]}\t");
                    if (j > i && a[i, j] > x)
                        x = a[i, j];
                    else if (j < i && a[i, j] < n)
                        n = a[i, j];
                }
                Console.WriteLine();
            }
        }
        public void Three()
        {
            Console.WriteLine($"Минимальный: {n}\nМаксимальный: {x}");
        }
        class Program
        {
            static void Main(string[] args)
            {
                Matrix program = new Matrix();
                Console.WriteLine("Введите элементы матрицы");
                program.One();
                Console.WriteLine("Матрица");
                program.Two();
                Console.WriteLine("Результат");
                program.Three();
                while (Console.ReadKey().Key != ConsoleKey.Escape) ;
            }
        }
/*
        static void Main(string[] args)
        {          
            int[,] a = new int[5, 5];
            Console.WriteLine("Элементы массива: ");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            int x = 0, n = int.MaxValue;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"{a[i, j]}\t");
                    if (j > i && a[i, j] > x)
                        x = a[i, j];
                    else if (j < i && a[i, j] < n)
                        n = a[i, j];
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine($"Минимальный: {n}\nМаксимальный: {x}");
            while (Console.ReadKey().Key != ConsoleKey.Escape) ;
        }
    */
    }
}