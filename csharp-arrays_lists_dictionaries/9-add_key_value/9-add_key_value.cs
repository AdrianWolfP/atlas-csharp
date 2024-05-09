using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, string> AddKeyValue(Dictionary<string, string> myDict, string key, string value)
    {
        // Check if the dictionary already contains the key
        if(myDict.ContainKey(key))
        {
            // If the key exists, update the value
            myDict[key] = value;
        }
        else
        {
            // If the key does not exists
            // add a new key-value pair to the dictonary
            myDict.Add(key, value);
        }

        // Return the modified dictonary
        return myDict;
    }
}