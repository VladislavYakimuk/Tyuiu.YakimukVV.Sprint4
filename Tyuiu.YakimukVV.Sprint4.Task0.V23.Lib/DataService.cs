using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.YakimukVV.Sprint4.Task0.V23.Lib
{
    public class DataService : ISprint4Task0V23
    {
        public int GetMultOddArrEl(int[] array)
        {
            int product = 1;
            bool hasOdd = false;

            foreach (int number in array)
            {
                if (number % 2 != 0) 
                {
                    product *= number;
                    hasOdd = true; 
                }
            }

            return hasOdd ? product : 0; 
        }
    }
}
