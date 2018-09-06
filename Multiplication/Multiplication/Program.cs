using System;

namespace Multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            GetResults(9, 12);
        }

        public static int[,] GetResults(int start, int stop)
        {
            int array_Column_And_Row = (stop - start) + 2;
            int[,] array = new int[array_Column_And_Row , array_Column_And_Row];
            for(int col = start; col <= stop; col++)
            {
                array[0, (col - start) + 1] = col;
                array[(col - start) + 1, 0] = col;
            }
            for(int row = 1; row < array_Column_And_Row; row++)
            {
                for(int col = 1; col < array_Column_And_Row; col++)
                {
                    array[row, col] = array[0, row] * array[col, 0];
                }
            }
            return array;
        }
    }
}