using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.YakimukVV.Sprint4.Task3.V8.Lib
{
    public class DataService : ISprint4Task3V8
    {
        public int Calculate(int[,] array)
        {
            int min = array[0, 3];  

            for (int i = 1; i < array.GetLength(0); i++)
            {
                if (array[i, 3] < min)
                {
                    min = array[i, 3];  
                }
            }

            return min;
        }
    }
}
