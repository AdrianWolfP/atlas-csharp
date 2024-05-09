using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        int? max = null;
        string res = "";
        foreach(string key in myList.Keys)
            if(!(max >= myList[key]))
            {
                max = myList[key];
                res = key;
            }
        if(max == null)
            return "None";
        return res;
    }
}