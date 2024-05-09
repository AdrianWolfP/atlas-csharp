using System
using System.Collections.Generic;

class Dictionary
{
    public static int NumberOfKeys(Dictionary<string, string> myDict)
    {
        // Initialize a counter to store the number of keys
        int i = 0;

        // Iterate through each keys in the dictionary
        foreach(string key in myDict.Keys)
        {
            // Increment the counter for each keys found
            i++;
        }

        // Return the total number of keys
        return i;
    }
}