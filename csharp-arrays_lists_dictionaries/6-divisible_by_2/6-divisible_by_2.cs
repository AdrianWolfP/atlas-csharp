using System;
using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        // Create a new list to store the results
        List<bool> res = new List<bool>();
        
        // Iterate through each integer in the input list
        foreach(int i in myList)
        {
            // Check is the current integer is divisible by 2
            // and add the result (true or false) to the result
            res.Add(i%2==0);
        }

        // Return the list of boolean values indicating divisibility by 2
        return res;
    }
}