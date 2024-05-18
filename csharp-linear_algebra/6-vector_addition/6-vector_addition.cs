using System;
/// <summary>
/// A static class containing methods for performing vector math operations.
/// </summary>
public static class VectorMath
{
    /// <summary>
    /// This method calculates the magnitude (length) of a double array (vector) representing a 2D or 3D vector.
    /// The method checks if the length of the input vector is within the valid range (2-3).
    /// If the input vector does not meet this condition, the method returns -1 to indicate an error.
    /// </summary>
    /// <param name="vector">The double array representing a 2D or 3D vector.</param>
    /// <returns>The magnitude (length) of the input vector, or -1 to indicate an error.</returns>
    /// <exception cref="ArgumentException">Thrown when the length of the input vector is outside the valid range (2-3).</exception>
    public static double Magnitude(double[] vector)
    {
        // Check if the length of the input vector is within the valid range (2-3).
        if ( vector.Length > 3 || vector.Length < 2)
            // Return -1 to indicate an error.
            return -1;
        
        // Calculate the sum of the squares of the vector's elements.
        double sum = 0;
        foreach (double i in vector)
            sum += i * i;
        // Return the magnitude (length) of the input vector.
        return Math.Round(Math.Sqrt(sum), 2);
    }

    /// <summary>
    /// This method takes in two double arrays (vector1 and vector2) and returns the sum of their elements.
    /// The method checks if the length of the input vectors are equal and within the valid range (2-3).
    /// If the input vectors do not meet these conditions, the method returns an array containing a single element (-1) to indicate an error.
    /// </summary>
    /// <param name="vector1">The first double array to add.</param>
    /// <param name="vector2">The second double array to add.</param>
    /// <returns>An array of doubles containing the sum of the input vectors, or an array containing a single element (-1) to indicate an error.</returns>
    /// <exception cref="ArgumentException">Thrown when the length of the input vectors are not equal or are outside the valid range (2-3).</exception>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        // Check if the length of the input vectors are equal and within the valid range (2-3).
        if (vector1.Length != vector2.Length || vector1.Length > 3 || vector1.Length < 2)
            // Return an array containing a single element (-1) to indicate an error.
            return new double[] {-1};

        // Create a new array to store the sum of the input vectors.
        double[] sum = new double[vector1.Length];
        // Iterate through the elements of the input vectors and add them together.
        for (int i = 0; i < vector1.Length; i++)
            sum[i] = vector1[i] + vector2[i];
        // Return the array containing the sum of the input vectors.
        return sum;
    }
}   