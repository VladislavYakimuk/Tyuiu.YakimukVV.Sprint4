using Tyuiu.YakimukVV.Sprint4.Task1.V29.Lib;
namespace Tyuiu.YakimukVV.Sprint4.Task1.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[14];
            Console.WriteLine("Введите 14 целых чисел от 1 до 9:");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            DataService dataService = new DataService();
            int sum = dataService.Calculate(array);

            Console.WriteLine($"Сумма нечетных элементов массива: {sum}");
        }
    }
}
