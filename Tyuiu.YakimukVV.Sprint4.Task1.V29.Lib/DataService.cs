using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.YakimukVV.Sprint4.Task1.V29.Lib
{
    public class DataService : ISprint4Task1V29
    {
        public int Calculate(int[] array)
        {
            int sum = 0;

            foreach (int num in array)
            {
                if (num % 2 != 0)
                {
                    sum += num;
                }
            }

            return sum;
        }
    }
}
