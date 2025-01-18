﻿using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KonstantinovaJN.Sprint6.Task3.V17.Lib
{
    public class DataService : ISprint6Task3V17
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;
            int[] newcol = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                newcol[i] = matrix[i, 3];
            }
            Array.Sort(newcol);
            for (int i = 0; i < rows; i++)
            {
                matrix[i, 3] = newcol[i];
            }
            return matrix;
        }
    }
}