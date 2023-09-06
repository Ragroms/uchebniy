namespace прак_4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s = 0; // сумма отр чисел
            int k = 0; // количество отр чисел
            int p = 1; // произведение пол чисел
            Console.WriteLine("Введите кол-во чисел в последовательности: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];         
            int i;
            Console.WriteLine("Ввод последовательности");
            for (i = 0; i <= n; i++)
            {
                Console.WriteLine("Введите "+ i+ "-е число:") ;
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Вывод последовательности");
           if (i > 0)
            {
                p = p * i;
                Console.WriteLine("Произведение положительных чисел: " + p);
            }
            if (i < 0)
            {
                s = s + i;
                k++;
                Console.WriteLine("Среднее арифметическое отрицательных чисел: " + s / k);
            }

            while (Console.ReadKey().Key != ConsoleKey.Escape) ;
        }
    }
}
