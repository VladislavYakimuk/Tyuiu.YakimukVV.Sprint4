using Tyuiu.YakimukVV.Sprint4.Task2.V13.Lib;
using System;

namespace Tyuiu.YakimukVV.Sprint4.Task2.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[13];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(2, 10);
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();

            DataService dataService = new DataService();

            int result = dataService.Calculate(array);

            Console.WriteLine($"Произведение четных элементов массива: {result}");
        }
    }
}
