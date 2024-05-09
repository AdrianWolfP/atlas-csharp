using System;
using System.Collections.Generic;

class List
{
    public static List<int> DeleteAt(List<int> myList, int index)
    {
        // Checks if the index is within the value range of the list
        if(index < 0 || index >= myList.Count)
        {
            
            // If the index is out of range, print an error message and return the original list
            Console.WriteLine("Index is out of range");
            return myList;
        }

        // Remove the element at the specified index from the list
        myList.Remove(myList[index]);
        return myList;
    }
}