using System;

class Array
{
   public static int[] ReplaceElement(int[] array, int index, int n)
   {
        // Check is the index is within the bounds of the array
        if (index < 0 || index >= array.Length)
        {
            // If the index is out of range
            //print an error message
            Console.WriteLine("Index out of range");
        }
        else
        {
            // If the index is within bounds
            // replace the element at that index with the new value (n)
            array[index] = n;
        }
        // Return the modified array
        return array;
   } 
}