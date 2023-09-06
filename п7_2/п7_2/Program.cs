using System.ComponentModel;
using System.Globalization;

namespace п7_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j;           
            Console.Write("Размерность массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[n, n];
            Console.WriteLine("Заполнение массива: ");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Просмотр массива: ");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("  " + a[i, j]);
                }
                Console.WriteLine();
            }
            for (i = 0; i < n; i++)
            {
                int c = 0;
                for (j = 0; j < n; j++)
                {
                    if (a[j, i] >= 0)
                    {
                        c++;
                    }
                }
                if (c == a.GetLength(0))
                {
                    int s = 0;
                    for (j = 0; j < n; j++)
                    {
                        s += a[j, i];
                    }                    
                    Console.WriteLine("Сумма элементов в {0} столбце равна: {1}", i + 1, s);
                }
            }            
            while (Console.ReadKey().Key != ConsoleKey.Escape) ;
        }
    }   
}