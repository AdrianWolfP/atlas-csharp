using System;

/// <summary>
/// Matrix Math class
/// </summary>
public static class MatrixMath
{
    /// <summary>
/// This method adds two 2D double arrays (matrices) of the same dimensions.
/// The method checks if the dimensions of the input matrices are within the valid range (2x2 to 3x3).
/// If the input matrices do not meet this condition, the method returns a new 2D double array containing a single element, -1, to indicate an error.
/// </summary>
/// <param name="matrix1">The first 2D double array representing a 2D or 3D matrix.</param>
/// <param name="matrix2">The second 2D double array representing a 2D or 3D matrix.</param>
/// <returns>A new 2D double array containing the sum of the input matrices, or a new 2D double array containing a single element, -1, if the input matrices are invalid.</returns>
/// <exception cref="ArgumentException">Thrown when the dimensions of the input matrices are outside the valid range (2x2 to 3x3) or when they are not equal.</exception>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        // Check if the dimensions of the input matrices are within the valid range (2x2 to 3x3) and if they are equal.
        if (matrix1.GetLength(0) != matrix2.GetLength(0) ||
        matrix1.GetLength(1) != matrix2.GetLength(1) ||
        matrix1.GetLength(0) < 2 || matrix1.GetLength(0) > 3 ||
        matrix1.GetLength(1) < 2 || matrix1.GetLength(1) > 3)
            // Return a new 2D double array containing a single element, -1, if the input matrices are invalid.
            return new double[,] {{-1}};
        double[,] sum = new double[matrix1.GetLength(0), matrix1.GetLength(1)];
        for (int i = 0; i < matrix1.GetLength(0); i++)
            for (int j = 0; j < matrix1.GetLength(1); j++)
                sum[i, j] = matrix1[i, j] + matrix2[i, j];
        return sum;
    }
}