using System;

namespace Text
{
    public static class Str
    {
       public static bool IsPalindrome(string s)
       {
        if (s == null || s == "")
            return true;
        s = s.ToLower();
        s = s.Replace(" ", "").Replace(".", "").Replace(":", "").Replace(",", "").Replace("?", "").Replace("!", "");
        for (int i = 0; i < s.Length - (i + 1); i++)
        {
            if (s[i] != s[s.Length - (i + 1)])
                return false;
        }
        return true;
       } 
    }
}