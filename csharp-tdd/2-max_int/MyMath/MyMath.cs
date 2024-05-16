using System.Collections.Generic;

namespace MyMath
{
    /// <summary>
    /// A static class for matrix operations.
    /// </summary>
    public static class Matrix
    {
        /// <summary>
        /// Divides each element of the matrix by a given number.
        /// </summary>
        /// <param name="matrix">The matrix to divide.</param>
        /// <param name="num">The number to divide by.</param>
        /// <returns>A new matrix with each element divided by num, or null if matrix or num is null or num is 0.</returns>
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (num == 0)
            {
                System.Console.WriteLine("Num cannot be 0");
                return null;
            }
            if (matrix == null)
                return null;
            
            int[,] res = new int[matrix.GetLength(0), matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    res[i, j] = matrix[i, j] / num;

            return res;
        }
    }

    /// <summary>
    /// A static class for mathematical operations.
    /// </summary>
    public static class Operations
    {
        /// <summary>
        /// Returns the maximum value in a list of integers.
        /// </summary>
        /// <param name="nums">The list of integers.</param>
        /// <returns>The maximum value in the list, or 0 if the list is null or empty.</returns>
        public static int Max(List<int> nums)
        {
            int? res = null;
            if (nums != null)
            {
                foreach (int i in nums)
                {
                if (!(res >= i))
                    res = i;
                }
            }
            return res.GetValueOrDefault();
        }
    }
}