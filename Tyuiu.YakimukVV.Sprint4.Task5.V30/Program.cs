using Tyuiu.YakimukVV.Sprint4.Task5.V30.Lib;
using System;

namespace Tyuiu.YakimukVV.Sprint4.Task5.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dataService = new DataService();

            int[,] matrix = new int[5, 5];
            Random random = new Random();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = random.Next(-2, 5); 
                }
            }

            int sumOfPositiveElements = dataService.Calculate(matrix);

            Console.WriteLine("Сумма положительных элементов: " + sumOfPositiveElements);
        }
    }
}
