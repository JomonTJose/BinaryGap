using System;

namespace BinaryGap
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[] { 2, 3 };
            int[][] jagged_arr =
                     {
                        new int[] {1, 2, 3},
                        new int[] {11, 34, 67},
                        new int[] {89 },
                        new int[] {0, 45, 78, 53, 99}
                    };
            int[][,] jagged_arr1 = new int[4][,]
                {
                    new int[, ] { {1, 3}, {5, 7} },
                    new int[, ] { {0, 2}, {4, 6}, {8, 10} },
                    new int[, ] { {7, 8}, {3, 1}, {0, 6} },
                    new int[, ] { {11, 22}, {99, 88}, {0, 9} }
                };


        }

    }
}
