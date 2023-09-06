using System;
using System.Collections.Generic;
using System.IO;

namespace прак_14
{
    class ListItem
    {
        public string Mark { get; set; }
        public string Manufacturer { get; set; }
        public string Album { get; set; }
        public int RecordingTime { get; set; }
        public ListItem Next { get; set; }
    }
    class LinkedList
    {
        private ListItem head;
        public void AddItem(ListItem item)
        {
            if (head == null)
            {
                head = item;
            }
            else
            {
                ListItem current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = item;
            }
        }
        public void RemoveItem(ListItem item)
        {
            if (head == null)
            {
                return;
            }
            if (head == item)
            {
                head = head.Next;
                return;
            }
            ListItem current = head;
            while (current.Next != null)
            {
                if (current.Next == item)
                {
                    current.Next = current.Next.Next;
                    return;
                }
                current = current.Next;
            }
        }
        public ListItem FindItem(string mark)
        {
            ListItem current = head;
            while (current != null)
            {
                if (current.Mark == mark)
                {
                    return current;
                }
                current = current.Next;
            }
            return null;
        }
        public void InsertItem(ListItem newItem, ListItem afterItem)
        {
            if (head == null)
            {
                head = newItem;
                return;
            }
            if (afterItem == null)
            {
                newItem.Next = head;
                head = newItem;
                return;
            }
            ListItem current = head;
            while (current != null)
            {
                if (current == afterItem)
                {
                    newItem.Next = current.Next;
                    current.Next = newItem;
                    return;
                }
                current = current.Next;
            }
        }
        public void PrintList()
        {
            ListItem current = head;
            while (current != null)
            {
                Console.WriteLine("Марка: {0}, Изготовитель: {1}, Название: {2}, Время записи: {3}", current.Mark, current.Manufacturer, current.Album, current.RecordingTime);
                current = current.Next;
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                LinkedList list = new LinkedList();
                string[] lines = File.ReadAllLines("data.txt");
                foreach (string line in lines)
                {
                    string[] fields = line.Split(';');
                    ListItem item = new ListItem();
                    item.Mark = fields[0];
                    item.Manufacturer = fields[1];
                    item.Album = fields[2];
                    item.RecordingTime = int.Parse(fields[3]);
                    list.AddItem(item);
                }
                while (true)
                {
                    Console.WriteLine("Меню:\n1 - Просмотр,\n2 - Поиск,\n3 - Вставка,\n4 - Удаление,\n5 - Выход!");
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            list.PrintList();
                            break;
                        case 2:
                            Console.WriteLine("Введите марку кассеты для поиска:");
                            string mark = Console.ReadLine();
                            ListItem item = list.FindItem(mark);
                            if (item != null)
                            {
                                Console.WriteLine("Найден элемент: Марка: {0}, Изготовитель: {1}, Название: {2}, Время записи: {3}", item.Mark, item.Manufacturer, item.Album, item.RecordingTime);
                            }
                            else
                            {
                                Console.WriteLine("Элемент не найден");
                            }
                            break;
                        case 3:
                            Console.WriteLine("Введите данные для нового элемента (Марка, Изготовитель, Название, Время записи) через запятую:");
                            string[] fields = Console.ReadLine().Split(',');
                            ListItem newItem = new ListItem();
                            newItem.Mark = fields[0];
                            newItem.Manufacturer = fields[1];
                            newItem.Album = fields[2];
                            newItem.RecordingTime = int.Parse(fields[3]);
                            Console.WriteLine("Введите марку кассеты, после которой нужно вставить новый элемент (или оставьте пустым, чтобы вставить в начало списка):");
                            string afterMark = Console.ReadLine();
                            ListItem afterItem = null;
                            if (!string.IsNullOrEmpty(afterMark))
                            {
                                afterItem = list.FindItem(afterMark);
                            }
                            list.InsertItem(newItem, afterItem);
                            break;
                        case 4:
                            Console.WriteLine("Введите марку кассеты для удаления:");
                            string markToRemove = Console.ReadLine();
                            ListItem itemToRemove = list.FindItem(markToRemove);
                            if (itemToRemove != null)
                            {
                                list.RemoveItem(itemToRemove);
                                Console.WriteLine("Элемент удален");
                            }
                            else
                            {
                                Console.WriteLine("Элемент не найден");
                            }
                            break;
                        case 5:
                            return;
                        default:
                            Console.WriteLine("Неверный выбор");
                            break;
                    }
                }
            }
        }
    }
}
