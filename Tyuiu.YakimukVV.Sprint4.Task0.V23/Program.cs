using Tyuiu.YakimukVV.Sprint4.Task0.V23.Lib;

namespace Tyuiu.YakimukVV.Sprint4.Task0.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 9, 3, 7, 1, 5, 5, 3, 2, 1, 7 };

            DataService dataService = new DataService();

            int result = dataService.GetMultOddArrEl(array);

            Console.WriteLine("Произведение нечетных элементов массива: " + result);
        }
    }
}
