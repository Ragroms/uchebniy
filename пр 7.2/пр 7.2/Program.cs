using System.Drawing;

namespace пр_7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер матрицы: ");
            int s = Convert.ToInt32(Console.ReadLine());
            int[,] A = new int[s, s];
            int i, r;
            Console.WriteLine("Введите элементы массива: ");
            for (i = 0; i < s; i++)
            {               
                A[s,s] = Convert.ToInt32(Console.ReadLine());
            }
            for (int m = 0; m < s; m++)
            {
                for (int n = 0; n < s; n++)
                {
                    A[m,n] = r.Next(-s, s);
                    Console.Write(A[m, n]);
                }
                Console.WriteLine();
            }
                /*
                for (int m = 0; m < s; m++)
                {
                    for (int n = 0; n < s; n++)
                    {
                        a[m, n] = r.Next(-s, s);
                        Console.Write("{0}\t", a[m, n]);
                    }
                    Console.WriteLine();
                }
                */

                int[] y = new int[s];
            for (int m = 0; m < s; m++)
            {
                for (int n = 0; n < s; n++)
                {
                    if (A[m, n] > 0)
                    {
                        if (y[m] != 0)
                            y[m] *= A[m, n];
                        else
                            y[m] = A[m, n];
                    }
                }
            }
            for (i = 0; i < s; i++)
                Console.WriteLine("Строка {0} матрицы имеет произведение положительных элементов равное: {1}", i + 1, y[i]);

            while (Console.ReadKey().Key != ConsoleKey.Escape) ;
        }
    }
}