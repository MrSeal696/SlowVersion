using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace SlowProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа через пробел:");

            string input = Console.ReadLine();
            string[] parts = input.Split(' ');

            List<int> numbers = new List<int>();

            foreach (var part in parts)
            {
                numbers.Add(int.Parse(part));
            }

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            foreach (int number in numbers)
            {
                long result = HeavyCalculation(number);
                Console.WriteLine($"Факториал {number} = {result}");
            }

            stopwatch.Stop();
            Console.WriteLine($"Время выполнения: {stopwatch.ElapsedMilliseconds} мс");
        }

        static long HeavyCalculation(int n)
        {
            long result = 1;

            for (int i = 1; i <= n; i++)
            {
                result *= i;
                System.Threading.Thread.Sleep(10); // Имитируем тяжёлую операцию
            }

            return result;
        }
    }
}
