using System;

class Array
{
    public static void Reverse(int[] array)
    {
        // Check is the input array is not null
        // and has at least one element
        if (array != null && array.Length >= 1)
        {
            // Use the built-in Array.Reverse method
            // to reverse the array in place
            System.Array.Reverse(array);

            // Print the reversed array to the console
            // separated by spaces
            Console.WriteLine(string.Join(" ", array));
            
            // Return from the method
            return;
        }

        // If the array is null or empty
        // print an empty line
        Console.WriteLine();
    }
}   