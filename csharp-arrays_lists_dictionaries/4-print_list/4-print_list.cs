using System;
using System.Collections.Generic;
using System.Linq;

class List
{
    public static List<int> CreatePrint(int size)
    {
        // Check if the input size is valid (non-negative)
        if (size < 0)
        {
            // If the size is negative
            // print an error message and return null
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        // Create a list of numbers from 0 to size -1 using LINQ's Enumerable.Range
        List<int> numbers = Enumerable.Range(0, size).ToList();

        // Print the list of numbers to the console
        // separated by spaces
        Console.WriteLine(String.Join(" ", numbers));

        // Return the created list
        return numbers;
    }
}