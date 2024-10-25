using Tyuiu.YakimukVV.Sprint4.Task6.V8.Lib;
namespace Tyuiu.YakimukVV.Sprint4.Task6.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] data = { "Пицца", "Борщ", "Пельмени", "Омлет", "Салат", "Суп", "Роллы" };

            DataService dataService = new DataService();

            string[] result = dataService.Calculate(data);

            Console.WriteLine("Элементы массива, длина которых больше 4 символов:");
            foreach (string item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
