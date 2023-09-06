// See https://aka.ms/new-console-template for more information
using static System.Net.Mime.MediaTypeNames;

static class PR10 // Разработать консольное приложение, осуществляющее работу со строковыми данными. В программе в качестве метода оформить обработку данных. Дана символьная строка. Слово - последовательность символов между пробелами, не содержащая пробелы внутри себя. Определить длину самого короткого слова.


{
    public static string text;
    public static string str;
    static void Main(string[] args)
    {
        {
            Console.WriteLine("Добро пожаловать!♥");
            bool exit = false;
            while (exit != true)
            {
                Console.WriteLine("Выберите действие в меню: \n 1 - Ввод данных \n 2 - Проссмотр данных \n 3 - Обработка данных \n 4 - Выход");
                string menu = Console.ReadLine();

                switch (menu)
                {
                    case "1":
                        VOD();
                        break;
                    case "2":
                        PROSMOTR();
                        break;
                    case "3":
                        OBRABOTKA();
                        break;
                    case "4":
                        exit = true;
                        break;
                }
                Console.Clear();
            }
            static void VOD()
            {
                Console.WriteLine("Введите текст:");
                text = Console.ReadLine();
                Console.ReadKey();
            }
            static void PROSMOTR()
            {
                Console.WriteLine("Заданный текст:" + text);
                Console.ReadKey();
            }
            static void OBRABOTKA()
            {
                static void Reg(string[] args)
                //Ввод текста
                {
                    string text = Console.ReadLine();

                    int shortestWordLength = GetShortestWordLength(text);

                    Console.WriteLine($"Длина самого короткого слова: {shortestWordLength}");
                }

                // Метод для определения длины самого короткого слова в строке
                static int GetShortestWordLength(string input)
                {
                    string[] words = input.Split(' '); // Разбиваем строку на слова

                    int shortestWordLength = int.MaxValue; // Начальное значение для поиска минимальной длины слова

                    foreach (string word in words)
                    {
                        int length = word.Length;

                        if (length < shortestWordLength)
                        {
                            shortestWordLength = length;
                        }
                    }

                    return shortestWordLength;
                }
            }
        }
    }
}