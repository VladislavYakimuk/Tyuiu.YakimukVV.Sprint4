﻿using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.YakimukVV.Sprint4.Task5.V30.Lib
{
    public class DataService : ISprint4Task5V30
    {
        public int Calculate(int[,] matrix)
        {
            int sum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > 0) 
                    {
                        sum += matrix[i, j];
                    }
                }
            }

            return sum;
        }
    }
}
