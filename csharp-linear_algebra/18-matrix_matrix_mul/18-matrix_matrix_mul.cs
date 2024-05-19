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

    /// <summary>
    /// This method multiplies a 2D double array (matrix) by a scalar value.
    /// The method checks if the dimensions of the input matrix are within the valid range (2x2 to 3x3).
    /// If the input matrix does not meet this condition, the method returns a new 2D double array containing a single element, -1, to indicate an error.
    /// </summary>
    /// <param name="matrix">The 2D double array representing a 2D or 3D matrix.</param>
    /// <param name="scalar">The scalar value to multiply the input matrix by.</param>
    /// <returns>A new 2D double array containing the product of the input matrix and the scalar value, or a new 2D double array containing a single element, -1, if the input matrix is invalid.</returns>
    /// <exception cref="ArgumentException">Thrown when the dimensions of the input matrix are outside the valid range (2x2 to 3x3).</exception>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        // Check if the dimensions of the input matrix are within the valid range (2x2 to 3x3).
        if (matrix.GetLength(0) < 2 || matrix.GetLength(0) > 3 ||
        matrix.GetLength(1) < 2 || matrix.GetLength(1) > 3)
            // Return a new 2D double array containing a single element, -1, if the input matrix is invalid.
            return new double[,] {{-1}};
        // Create a new 2D double array to store the product of the input matrix and the scalar value.
        double[,] result = new double[matrix.GetLength(0), matrix.GetLength(1)];
        // Multiply each element of the input matrix by the scalar value.
        for (int i = 0; i < matrix.GetLength(0); i++)
            for (int j = 0; j < matrix.GetLength(1); j++)
                result[i, j] = matrix[i, j] * scalar;
        // Return the product of the input matrix and the scalar value.
        return result;
    }

    /// <summary>
    /// This method checks if the dimensions of a 2D double array (matrix) are within the valid range (2x2 to 3x3).
    /// </summary>
    /// <param name="matrix">The 2D double array representing a 2D or 3D matrix.</param>
    /// <returns>True if the dimensions of the input matrix are within the valid range (2x2 to 3x3), false otherwise.</returns>
    public static bool ValidateMatrix(double[,] matrix)
    {
        // Check if the dimensions of the input matrix are within the valid range (2x2 to 3x3).
        if (matrix.GetLength(0) < 2 || matrix.GetLength(0) > 3 ||
        matrix.GetLength(1) < 2 || matrix.GetLength(1) > 3)
            // Return false if the input matrix is invalid.
            return false;
        // Return true if the dimensions of the input matrix are within the valid range (2x2 to 3x3).
        return true;
    }

    /// <summary>
/// This method multiplies two 2D double arrays (matrices) of compatible dimensions.
/// The method checks if the number of columns of the first matrix is equal to the number of rows of the second matrix.
/// If the input matrices do not meet this condition, the method returns a new 2D double array containing a single element, -1, to indicate an error.
/// </summary>
/// <param name="matrix1">The first 2D double array representing a matrix.</param>
/// <param name="matrix2">The second 2D double array representing a matrix.</param>
/// <returns>A new 2D double array containing the product of the input matrices, or a new 2D double array containing a single element, -1, if the input matrices are invalid.</returns>
/// <exception cref="ArgumentException">Thrown when the dimensions of the input matrices are not compatible for multiplication.</exception>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        // Check if the number of columns of the first matrix is equal to the number of rows of the second matrix.
        if (matrix1.GetLength(1) != matrix2.GetLength(0))
            // Return a new 2D double array containing a single element, -1, if the input matrices are invalid.
            return new double[,] {{-1}};
        // Create a new 2D double array to store the product of the input matrices.
        double[,] result = new double[matrix1.GetLength(0), matrix2.GetLength(1)];
        // Multiply corresponding elements of the input matrices.
        for (int Row_A = 0; Row_A < matrix1.GetLength(0); Row_A++)
            for (int Col_B = 0; Col_B < matrix2.GetLength(1); Col_B++)
                for (int Col_A = 0; Col_A < matrix1.GetLength(1); Col_A++)
                    result[Row_A, Col_B] += matrix1[Row_A, Col_A] * matrix2[Col_A, Col_B];
        // Return the product of the input matrices.
        return result;
    }
}