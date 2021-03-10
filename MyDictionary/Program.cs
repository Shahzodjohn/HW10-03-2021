using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        public static object Userinfo { get; private set; }

        public static Dictionary<int, string> MyDictionary(int i)
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            Console.WriteLine("Введите имя человека: \n");
            string s;
            for (int j = 0; j < i; j++)
            {
                Console.WriteLine($"Name --> ", j);
                s = Console.ReadLine();
                dictionary.Add(j, s);
                Console.Clear();

            } return dictionary;
        } 
        
        
        
        static void Main(string[] args)
        {
            Console.WriteLine("Cколько имен хотите добавить? ");
            try
            {
                int i = int.Parse(Console.ReadLine());
                Dictionary<int, string> dictionary = Program.MyDictionary(i);
                ICollection<int> keys = dictionary.Keys;
                Console.WriteLine("База данных содержит: ");
                foreach (var j in keys)
                {
                    Console.WriteLine("Id -> {0} Name -> {1}",j, dictionary[j]);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный ввод! ");
            }

        }
    }
}
