using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.YakimukVV.Sprint4.Task6.V8.Lib
{
    public class DataService : ISprint4Task6V8
    {
        public string[] Calculate(string[] array)
        {
            return Array.FindAll(array, item => item.Length > 4);
        }
    }
}
