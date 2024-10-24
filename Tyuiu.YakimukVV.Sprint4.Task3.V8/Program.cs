using Tyuiu.YakimukVV.Sprint4.Task3.V8.Lib;
namespace Tyuiu.YakimukVV.Sprint4.Task3.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array =
            {
                { 4, 8, 3, 4, 8 },
                { 5, 3, 5, 7, 8 },
                { 3, 7, 2, 7, 7 },
                { 5, 2, 4, 6, 4 },
                { 4, 4, 6, 7, 2 }
            };

            var dataService = new DataService();
            int minInFourthColumn = dataService.Calculate(array);

            Console.WriteLine($"Минимальный элемент в четвёртом столбце: {minInFourthColumn}");
        }
    }
}
