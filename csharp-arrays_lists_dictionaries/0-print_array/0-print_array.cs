using System;
using System.Linq;
class Array 
{
    public static int[] CreatePrint(int size)
    {
        // Declare an integer array to store the result
        int[] IntArray;

        // Use the conditional operator to create the arra
        // based on the input size
        IntArray = size > 0 
            // If size is greater than 0, create an array of that size using an Enumerable.Range
            ? Enumerable.Range(0, size).ToArray()
            // If size is 0, create an empty array
            : (size == 0 ? new int[0]
            // If size is less than 0, return null 
            : null);
    }
}