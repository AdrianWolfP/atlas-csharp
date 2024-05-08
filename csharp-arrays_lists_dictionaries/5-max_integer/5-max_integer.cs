using System;
using System.Collections.Generic;

class List
{
    public static int MaxInteger(List<int> myList)
    {
        // Check if the input is null or  empty
        if (myList == null || myList.Count == 0)
        {
            // If the list is empty
            // print an error message and return sentinel value (-2) 
            Console.WriteLine("List is empty");
            return -1;
        }

        // Initiaklize the maximum value to the first element of the list
        int max = myList[0];

        // Iterate through the list to find the maximum value
        foreach (int num in myList)
        {

            // If the current number is greater than the current maximum
            // update the maximum
            if (num > max)
            {
                max = num;
            }
        }

        // Return the maximum value found in the list
        return max;
    }
}