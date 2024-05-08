using System;

class Array
{
    public static int ElementAt(int [] array, int index)
    {
        // Check if the index is within the bounds of the array
        if (index < 0 || index >= array.Length)
        {
            // If the index is out of range, print an error message 
            // and return sentinel value (-1)
            Console.WriteLine("Index out of range");
            return -1;
        }

        // If the array is within bounds
        // retrun the element at that index
        return array[index];
    }
}