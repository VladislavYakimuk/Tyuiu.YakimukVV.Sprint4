using tyuiu.cources.programming.interfaces.Sprint4;
using System.Linq;

namespace Tyuiu.YakimukVV.Sprint4.Task2.V13.Lib
{
    public class DataService : ISprint4Task2V13
    {
        public int Calculate(int[] array)
        {
            int product = 1;
            bool hasEven = false; 

            foreach (int number in array)
            {
                if (number % 2 == 0)
                {
                    product *= number;
                    hasEven = true;
                }
            }

            return hasEven ? product : 0;
        }
    }
}
