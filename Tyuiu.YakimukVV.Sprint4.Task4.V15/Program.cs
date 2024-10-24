using Tyuiu.YakimukVV.Sprint4.Task4.V15.Lib;
namespace Tyuiu.YakimukVV.Sprint4.Task4.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[5, 5];

            Console.WriteLine("Введите элементы массива 5 на 5 (значения от 2 до 6):");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            DataService dataService = new DataService();
            int sum = dataService.Calculate(matrix);

            Console.WriteLine($"Сумма нечетных элементов: {sum}");
        }
    }
}
