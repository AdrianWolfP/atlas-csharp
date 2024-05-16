using System;

namespace Text
{
    public static class Str
    {
        /// <summary>
        /// Returns the index of the first unique character in the given string.
        /// If all characters are non-unique, returns -1.
        /// </summary>
        /// <param name="s">The input string.</param>
        /// <returns>The index of the first unique character, or -1 if all characters are non-unique.</returns>
        public static int UniqueChar(string s)
        {
            // Check for null or empty string
            if (s == null || s.Length == 0)
                return -1;

            // Initialize index to 0    
            int index = 0;

            // Loop through the string
            for (int i = 1; i < s.Length; i++)
            {
                // Check for end of string
                if (index == s.Length)
                    retrun -1;

                // Check for non-unique character    
                if (s[index] == s[i] && !(index == i))
                {

                    // Increment index and restart loop
                    index++;
                    i = -1;
                    continue;
                }
            }

            // Return index of first unique character
            return index;
        }
    } 

}