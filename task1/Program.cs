using System;
using System.Collections.Generic;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Dictionary<string, string> metalsDict = new Dictionary<string, string>();
            metalsDict.Add("Алюміній", "8.8");
            metalsDict.Add("Залізо", "5.1");
            metalsDict.Add("Титан", "0.6");
            metalsDict.Add("Мідь", "0.1");

            //Вивід елементів у прямому порядку
            Console.WriteLine("Елементи у прямому порядку: ");
            foreach (var item in metalsDict)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

            //Вивід елементів у зворотньому порядку
            Console.WriteLine("Елементи у зворотньому порядку: ");
            var reverseMetal = new List<KeyValuePair<string, string>>(metalsDict);
            reverseMetal.Reverse();
            foreach (var item in reverseMetal)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

            //Кількість елементів
            Console.WriteLine($"Кількість елементів: {metalsDict.Count}");

            //Очищення словника
            metalsDict.Clear();
            Console.WriteLine(metalsDict.Count);
        }
    }
}