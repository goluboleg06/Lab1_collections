using System;
using System.Collections.Generic;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            int min = Int32.MaxValue;
            int max = Int32.MinValue;
            int mult;

            Console.WriteLine("К-ксть елементів: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{i + 1} елемент:");
                stack.Push(Convert.ToInt32(Console.ReadLine()));
            }
            foreach (int num in stack)
            {
                if (min > num) min = num;
                if (max < num) max = num;
            }
            mult = max * min;
            Console.WriteLine($"Мінімальне значення: {min}");
            Console.WriteLine($"Максимальне значення: {max}");
            Console.WriteLine($"Добуток мінімального і максимального: {mult}");
        }
    }
}
