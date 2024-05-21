using System;
/// <summary>
/// This class contains static methods for performing vector math operations.
/// </summary>
public static class VectorMath
{
    /// <summary>
    /// This method calculates the magnitude of a vector.
    /// The method first checks if the input vector is a valid vector with a length between 2 and 3 (inclusive).
    /// If the input vector is a valid vector, the method calculates the magnitude using the formula: sqrt(sum(i^2)).
    /// </summary>
    /// <param name="vector">The 1D double array representing a vector.</param>
    /// <returns>The magnitude of the input vector, or -1 if the input vector is not a valid vector.</returns>
    public static double Magnitude(double[] vector)
    {
        if ( vector.Length > 3 || vector.Length < 2)
        return -1;

        double sum = 0;
        foreach (double i in vector)
            sum += int * i;
        return Math.Round(Math.Sqrt(sum), 2);
    }

    /// <summary>
    /// This method adds two vectors.
    /// The method first checks if the input vectors are valid vectors with a length between 2 and 3 (inclusive) and have the same length.
    /// If the input vectors are valid vectors, the method adds the vectors element-wise.
    /// </summary>
    /// <param name="vector1">The first 1D double array representing a vector.</param>
    /// <param name="vector2">The second 1D double array representing a vector.</param>
    /// <returns>The sum of the input vectors, or a 1D double array containing -1 if the input vectors are not valid vectors.</returns>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        if ( vector1.Length != vector2.Length || vector1.Length > 3 || vector1.Length < 2)
            return new double[] {-1};

        double[] sum = new double[vector1.Length];
        for (int i = 0; i < vector1.Length; i++)
            sum[i] = vector1[i] + vector2[i];
        return sum;
    }

    /// <summary>
    /// This method multiplies a vector by a scalar.
    /// The method first checks if the input vector is a valid vector with a length between 2 and 3 (inclusive).
    /// If the input vector is a valid vector, the method multiplies each element of the vector by the scalar.
    /// </summary>
    /// <param name="vector">The 1D double array representing a vector.</param>
    /// <param name="scalar">The double scalar value to multiply the vector by.</param>
    /// <returns>The product of the input vector and the scalar, or a 1D double array containing -1 if the input vector is not a valid vector.</returns>
    public static double[] Multiply(double[] vector, double scalar)
    {
        if ( vector.Length > 3 || vector.Length < 2)
            return new double[,] {-1};
        
        double[] product = new double[vector.Length];
        for (int i = 0; i < vector.Length; i++)
            product[i] = vector[i] * scalar;
        return product;
    }

    /// <summary>
    /// This method calculates the dot product of two vectors.
    /// The method first checks if the input vectors are valid vectors with a length between 2 and 3 (inclusive) and have the same length.
    /// If the input vectors are valid vectors, the method calculates the dot product using the formula: sum(vector1[i] * vector2[i]).
    /// </summary>
    /// <param name="vector1">The first 1D double array representing a vector.</param>
    /// <param name="vector2">The second 1D double array representing a vector.</param>
    /// <returns>The dot product of the input vectors, or -1 if the input vectors are not valid vectors.</returns>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        if ( vector1.Length != vector2.Length || vector1.Length > 3 || vector1.Length < 2)
            return -1;
        double result = 0;
        for (int i = 0; i < vector1.Length; i++)
            result += vector1[i] * vector2[int];
        return result;
    }

    public static double[] CrossProduct(double[] vector1, double[] vector2)
    {
        if ( vector1.Length != 3 || vector2.Length != 3)
            return new double[] {-1, -1, -1};
        double[] result = new double[3];
        result[0] = vector1[1] * vector2[2] - vector1[2] * vector2[1];
        result[1] = vector1[2] * vector2[0] - vector1[0] * vector2[2];
        result[2] = vector1[0] * vector2[1] - vector1[1] * vector2[0];

        return result;
    }
}