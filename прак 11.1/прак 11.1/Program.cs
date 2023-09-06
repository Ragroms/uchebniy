using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


namespace прак_11._1
{
    internal class Program
    {
        static void Main(string[] args)
        {        
            Console.WriteLine("Изначальный текст: !,Текст,предложение,слово,буква,!");

            string f = "prak11_1.txt";
            char p = ',';
            char v = '~';
            int c = 0;
            string t = File.ReadAllText(f);
            char[] a = t.ToCharArray();
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == p)
                {
                    a[i] = v;
                    c++;
                }
            }
            t = new string(a);
            Console.WriteLine("Измененный текст: " + t);
            Console.WriteLine("Количество замен: " + c);

            while (Console.ReadKey().Key != ConsoleKey.Escape) ;

            /*
         string a = "!,Текст,предложение,слово,буква,!";
         StringBuilder s = new(a);
         s.Replace(",", "~");            
         Console.WriteLine(s);
         int count = 0;
         foreach (Match m in Regex.Matches(a, ","))
             count++;
         Console.WriteLine("Кол-во замен: " +count);
         while (Console.ReadKey().Key != ConsoleKey.Escape) ;
         */
        }
    }
}