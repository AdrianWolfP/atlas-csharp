using System;

class Matrix
{
    public static int [,] Square(int [,] myMatrix)
    {
        // Create a new matrix with the same dimensions as the input matrix
        int[,] squareMatrix = new int[myMatrix.GetLength(0), myMatrix.GetLength(1)];

        // Loop through each elements in the input matrix
        for(int i = 0; i < myMatrix.GetLength(0); i++)
        {
            for(int j = 0; j < myMatrix.GetLength(1); j++)
            {
                // Square the current element and store it in the corresponding position in the new matrix
                squareMatrix[i, j] = myMatrix[i, j] * myMatrix[i, j];
            }
        }

        // Return the new matrix with squared elements
        return squareMatrix;
    }
}   