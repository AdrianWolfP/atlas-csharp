using System;

namespace Text
{
    public static class Str
    {
        public static int CamelCase(string s)
        {
            if (s == null || s.Length == 0)
                return 0;
            int i = 1;
            foreach (char c in s)
            {
                if (Char.IsUpper(c))
                    i++;
            }
            return i;
        }
    }
}