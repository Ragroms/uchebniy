using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace прак_13
{
    struct C
    {
        public string b;
        public string f;
        public string a;
        public int t;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество записей: ");
            int n = Convert.ToInt32(Console.ReadLine());
            C[] db = new C[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("~Введите информацию о кассете №{0}", i + 1);
                Console.Write("Марка кассеты: ");
                db[i].b = Console.ReadLine();
                Console.Write("Фирма-изготовитель: ");
                db[i].f = Console.ReadLine();
                Console.Write("Название альбома: ");
                db[i].a = Console.ReadLine();
                Console.Write("Время записи (в минутах): ");
                db[i].t = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("База данных создана.");
            while (true)
            {
                Console.WriteLine("\nВыберите действие:");
                Console.WriteLine("1. Просмотр базы данных");
                Console.WriteLine("2. Поиск записи");
                Console.WriteLine("3. Выход");

                int c = int.Parse(Console.ReadLine());

                switch (c)
                {
                    case 1:
                        Console.WriteLine("\nБаза данных:");
                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine("Кассета №{0}", i + 1);
                            Console.WriteLine("Марка кассеты: {0}", db[i].b);
                            Console.WriteLine("Фирма-изготовитель: {0}", db[i].f);
                            Console.WriteLine("Название альбома: {0}", db[i].a);
                            Console.WriteLine("Время записи (в минутах): {0}", db[i].t);
                            Console.WriteLine();
                        }
                        break;
                    case 2:
                        Console.WriteLine("\nВведите критерий поиска (марка кассеты, фирма-изготовитель, название альбома или время записи):");
                        string s = Console.ReadLine();
                        Console.WriteLine("\nРезультаты поиска:");
                        for (int i = 0; i < n; i++)
                        {
                            if (db[i].b == s || db[i].f == s || db[i].a == s || db[i].t.ToString() == s)
                            {
                                Console.WriteLine("Кассета №{0}", i + 1);
                                Console.WriteLine("Марка кассеты: {0}", db[i].b);
                                Console.WriteLine("Фирма-изготовитель: {0}", db[i].f);
                                Console.WriteLine("Название альбома: {0}", db[i].a);
                                Console.WriteLine("Время записи (в минутах): {0}", db[i].t);
                                Console.WriteLine();
                            }
                        }
                        break;
                    case 3:
                        Console.WriteLine("\nВыход из программы.");
                        return;

                    default:
                        Console.WriteLine("\nОшибка: неверный выбор.");
                        break;
                }               
            }
            /*public class Kasset
                {
                    public string name, marka, firm, time;
                }
                public void ReadDataFromFiles(string filePath);
                string filePath = "C:\\Users\\Juliya\\Documents\\Колледж\\Програмирование\\Кассеты.txt";
                public class Database
                {
                    Database db = new Database();
                }
                static void Main(string[] args)
                {
                    db.ReadDataFromFiles(filePath);
                    Console.Write("Введите номер Кассеты: ");
                    int k = Convert.ToInt32(Console.ReadLine());

                    Kasset q1 = new Kasset ();
                    q1.marka = "Mihoyo";
                    q1.firm = "Ли Юэ";
                    q1.name = "Яо Яо";           
                    q1.time = "60 сек.";
                    if (k == 1)
                    {
                        Console.WriteLine($"Марка кассеты: {q1.marka}\nФирма-изготовитель: {q1.firm}\nНазвание альбома: {q1.name}\nВремя записи: {q1.time}");
                    }

                    Kasset q2 = new Kasset();
                    q2.marka = "Hoyoverse";
                    q2.firm = "Инадзума";
                    q2.name = "Саю";
                    q2.time = "12 ч.";
                    if (k == 2)
                    {
                        Console.WriteLine($"Марка кассеты: {q2.marka}\nФирма-изготовитель: {q2.firm}\nНазвание альбома: {q2.name}\nВремя записи: {q2.time}");
                    }

                    Kasset q3 = new Kasset();
                    q3.marka = "Hoyolab";
                    q3.firm = "Моншдтат";
                    q3.name = "Кли";
                    q3.time = "5 мин.";
                    if (k == 3)
                    {
                        Console.WriteLine($"Марка кассеты: {q3.marka}\nФирма-изготовитель: {q3.firm}\nНазвание альбома: {q3.name}\nВремя записи: {q3.time}");
                    }*/
        }
    }
}