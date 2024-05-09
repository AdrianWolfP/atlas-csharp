using System;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        // Initialize a 5x5 integer array with all elements set to zero
        int[,] myArray = new int[5, 5];
        
        // Set the element at position (2, 2) to 1
        myArray[2, 2] = 1;

        // Loop through each element in the array
        for(int i = 0; i < 5; i++)
        {
            // Loop through each element in the current row
            for(int j = 0; j < 5; j++)
            {
                // Write the current element to the console
                Console.Write(myArray[i, j]);
                
                // If not on the last column, write a space to separate the elements
                if(j < 4)
                    Console.Write(" ");
            }

            // Write a newline character to move to the next row
            Console.WriteLine();
        }
    }
}