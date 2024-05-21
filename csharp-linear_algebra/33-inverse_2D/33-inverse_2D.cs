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
/// This method checks if a 2D double array (matrix) is a valid 2x2 matrix.
/// </summary>
/// <param name="matrix">The 2D double array representing a matrix.</param>
/// <returns>True if the input matrix is a valid 2x2 matrix, false otherwise.</returns>
    static bool ValidateMatrix2D(double[,] matrix)
    {
        return (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2);
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
        // Return a new 2D double array containing a single element, -1, if the input matrices are invalid.
        double[,] result = new double[matrix1.GetLength(0), matrix2.GetLength(1)];
        // Multiply corresponding elements of the input matrices.
        for (int Row_A = 0; Row_A < matrix1.GetLength(0); Row_A++)
            for (int Col_B = 0; Col_B < matrix2.GetLength(1); Col_B++)
                for (int Col_A = 0; Col_A < matrix1.GetLength(1); Col_A++)
                    result[Row_A, Col_B] += matrix1[Row_A, Col_A] * matrix2[Col_A, Col_B];
        // Return the product of the input matrices.
        return result;
    }

    /// <summary>
/// This method rotates a 2x2 matrix by a specified angle.
/// The method checks if the input matrix is a valid 2x2 matrix.
/// If the input matrix is invalid, the method returns a new 2D double array containing a single element, -1, to indicate an error.
/// </summary>
/// <param name="matrix">The 2D double array representing a 2x2 matrix.</param>
/// <param name="angle">The angle of rotation in radians.</param>
/// <returns>A new 2D double array containing the rotated matrix, or a new 2D double array containing a single element, -1, if the input matrix is invalid.</returns>
/// <exception cref="ArgumentException">Thrown when the input matrix is not a valid 2x2 matrix.</exception>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        // Negate the angle of rotation.
        angle *= -1;
        // Check if the input matrix is a valid 2x2 matrix.
        if (! ValidateMatrix2D(matrix))
            // Return a new 2D double array containing a single element, -1, if the input matrix is invalid.
             return new double[,] {{-1}};
        // Create a new 2D double array to store the rotated matrix.
        double[,] result = new double[2, 2], rotation = new double[2,2];
        // Set the elements of the rotation matrix.
        rotation[0, 0] = Math.Cos(angle);
        rotation[0, 1] = Math.Sin(angle);
        rotation[1, 0] = Math.Sin(angle);
        rotation[1, 1] = Math.Cos(angle);
        result = Multiply(matrix, rotation);
        for(int i = 0; i < result.GetLength(0); i++)
            for(int j = 0; j < result.GetLength(1); j++)
                result[i, j] = Math.Round(result[i, j], 2);
        return result; 
    }

    /// <summary>
/// This method applies a shear transformation to a 2x2 matrix.
/// The method checks if the input matrix is a valid 2x2 matrix and if the direction of shear is either 'x' or 'y'.
/// If the input matrix or direction of shear is invalid, the method returns a new 2D double array containing a single element, -1, to indicate an error.
/// </summary>
/// <param name="matrix">The 2D double array representing a 2x2 matrix.</param>
/// <param name="direction">The direction of shear, either 'x' or 'y'.</param>
/// <param name="factor">The factor of shear.</param>
/// <returns>A new 2D double array containing the sheared matrix, or a new 2D double array containing a single element, -1, if the input matrix or direction of shear is invalid.</returns>
/// <exception cref="ArgumentException">Thrown when the input matrix is not a valid 2x2 matrix or the direction of shear is not 'x' or 'y'.</exception>
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        // Check if the input matrix is a valid 2x2 matrix.
        if (! ValidateMatrix2D(matrix))
            // Return a new 2D double array containing a single element, -1, if the input matrix is invalid.
            return new double[,] {{-1}};
        // Check if the direction of shear is either 'x' or 'y'.
        if (!(direction == 'x' || direction == 'y'))
            // Return a new 2D double array containing a single element, -1, if the direction of shear is invalid.           
            return new double[,] {{-1}};
        // Create a new 2D double array to store the shear matrix.
        double[,] shear;
        // Set the elements of the shear matrix based on the direction of shear.
        if (direction == 'y')
            shear = new double[,] {{1, factor}, {0, 1}};
        else
            shear = new double[,] {{1, 0}, {factor, 1}};
        // Multiply the input matrix by the shear matrix.
        return Multiply(matrix, shear);
    }

    /// <summary>
/// This method transposes a 2D double array (matrix).
/// The method creates a new 2D double array with the dimensions of the input matrix swapped.
/// The method then copies the elements of the input matrix to the new 2D double array, with the row and column indices swapped.
/// </summary>
/// <param name="matrix">The 2D double array representing a matrix.</param>
/// <returns>A new 2D double array containing the transposed matrix.</returns>
    public static double[,] Transpose(double[,] matrix)
    {
        // Create a new 2D double array with the dimensions of the input matrix swapped.
        double[,] result = new double[matrix.GetLength(1), matrix.GetLength(0)];
        // Copy the elements of the input matrix to the new 2D double array, with the row and column indices swapped.
        for(int i = 0; i < matrix.GetLength(0); i++)
            for(int j = 0; j < matrix.GetLength(1); j++)
                result[j, i] = matrix[i, j];
        // Return the transposed matrix.
        return result;
    }

    /// <summary>
    /// This method calculates the determinant of a square matrix.
    /// The method first checks if the input matrix is a valid square matrix.
    /// If the input matrix is a 2x2 matrix, the method calculates the determinant using the formula: a*d - b*c.
    /// If the input matrix is a larger square matrix, the method calculates the determinant using the Leibniz formula for the determinant of a matrix.
    /// </summary>
    /// <param name="matrix">The square 2D double array representing a matrix.</param>
    /// <returns>The determinant of the input matrix, or -1 if the input matrix is not a valid square matrix.</returns>
    public static double Determinate(double[,] matrix)
    {
        // Check if the input matrix is a valid square matrix.
        if (!ValidateMatrix(matrix))
        // Return -1 if the input matrix is not a valid square matrix.
        return -1;
        // Calculate the determinant of the input matrix.
        if (ValidateMatrix2D(matrix))
            // Calculate the determinant using the formula: a*d - b*c.
            return Math.Round(matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0], 2);
        double result = 0;
        double? temp = null;
        // Calculate the determinant using the Leibniz formula for the determinant of a matrix.
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            temp = null;
            for(int j = 0; j < matrix.GetLength(1); j++)
                temp = temp.GetValueOrDefault(1) * matrix[j, (i + j) % matrix.GetLength(1)];
            result += temp.GetValueOrDefault(0);
        }
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            temp = null;
            for(int j = 0; j < matrix.GetLength(1); j++)
            {
                temp = temp.GetValueOrDefault(1) * matrix[matrix.GetLength(1) - 1 - j, (i + j) % matrix.GetLength(1)];
            }
            result -= temp.GetValueOrDefault(0);
        }
        // Return the determinant of the input matrix.
        return Math.Round(result, 2);
    }

    /// <summary>
/// This method calculates the inverse of a 2x2 matrix.
/// The method first checks if the input matrix is a valid 2x2 matrix.
/// If the input matrix is a valid 2x2 matrix, the method calculates the determinant of the matrix.
/// If the determinant is not zero, the method calculates the inverse using the formula: (1/det) * adj(matrix).
/// </summary>
/// <param name="matrix">The 2D double array representing a 2x2 matrix.</param>
/// <returns>The inverse of the input matrix, or a 2D double array containing -1 if the input matrix is not a valid 2x2 matrix or if the determinant is zero.</returns>
    public static double[,] Inverse2D(double[,] matrix)
    {
        if (!ValidateMatrix2D(matrix))
            return new double[,] {{-1}};
        double det = Determiant(matrix);
        if (det == 0)
            return new double[,] {{-1}};
        double[,] result = new double[,] {
            {matrix[1, 1], -1 * matrix[0, 1]},
            {-1 * matrix[1, 0], matrix[0, 0]}};
        result = MultiplyScalar(result, 1 / det);
        return result;
    }

    /// <summary>
/// This method calculates the inverse of a 3x3 matrix.
/// The method first calculates the determinant of the input matrix.
/// If the determinant is not zero, the method calculates the inverse using the formula: (1/det) * adj(matrix).
/// </summary>
/// <param name="matrix">The 2D double array representing a 3x3 matrix.</param>
/// <returns>The inverse of the input matrix, or a 2D double array containing -1 if the determinant is zero.</returns>
    public static double[,] Inverse3D(double[,] matrix)
    {
        double det = Determinant(matrix);
        if (det == 0)
            return new double[,] {{-1}};
        double[,] result = new double[3, 3];
        double a, b, c, d, e, f, g, h, i;
        a = matrix[0, 0];
        b = matrix[0, 1];
        c = matrix[0, 2];
        d = matrix[1, 0];
        e = matrix[1, 1];
        f = matrix[1, 2];
        g = matrix[2, 0];
        h = matrix[2, 1];
        i = matrix[2, 2];
        result[0, 0] = e * i - f * h;
        result[0, 1] = -1 * (d * i - f * g);
        result[0, 2] = d * h - e * g;
        result[1, 0] = -1 * (b * i - c * h);
        result[1, 1] = a * i - c * g;
        result[1, 2] = -1 * (a * h - b * g);
        result[2, 0] = b * f - c * e;
        result[2, 1] = -1 * (a * f - c * d);
        result[2, 2] = a * e - b * d;
        result = Transpose(result);
        result = MultiplyScalar(result, 1 / det);
        return result;
    }
}