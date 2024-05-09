using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, string> DeleteKeyValue(Dictionary<string, string> myDict, string key)
    {
        // Check if the dicionary contains the key
        if(myDict.ContainKey(key))
        {
            // If the key exists, remove the key-value pair from the dictionary
            myDict.Remove(key);
        }

        // Return the modified dictionary
        return myDict;
    }
}