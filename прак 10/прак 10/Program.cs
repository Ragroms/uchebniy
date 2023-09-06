namespace прак_10
{
    internal class Program
    {
        public static string s;
        static void Main(string[] args)
        {
            bool x = false;
            while (x != true)
            {
                Console.WriteLine("Меню:\n1 - Ввод данных\n2 - Просмотр данных\n3 - Обработка\n4 - Выход");
                Console.WriteLine("Выбор: ");
                string m = Console.ReadLine();
                switch (m)
                {
                    case "1":
                        one();
                        break;
                    case "2":
                        two();
                        break;
                    case "3":
                        three();
                        break;
                    case "4":
                        x = true;
                        break;
                }
                Console.Clear();
            }
            static void one()
            {
                Console.Write("Введите строку: ");
                s = Console.ReadLine();
                Console.ReadKey();
            }
            static void two()
            {
                Console.Write("Введенная строка: " + s);
                Console.ReadKey();
            }
            static void three()
            {
                string[] a = s.Split(" ");
                Console.WriteLine("Количество слов в строке: " + a.Length);
                Console.ReadKey();
            }

            while (Console.ReadKey().Key != ConsoleKey.Escape) ;
        }
    }
}