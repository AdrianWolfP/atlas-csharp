using System;
/// <summary>
/// Contains a static method for checking if an object is an instance of the Array class.
/// </summary>

public class Obj
{
    /// <summary>
    /// Determines whether the given object is an instance of the Array class.
    /// </summary>
    /// <param name="obj">The object to check.</param>
    /// <returns>True if the object is an instance of the Array class, false otherwise.</returns>
    public static bool IsInstanceOfArray(object obj)
    {
        if (obj is Array)
            return true;
        else
            return false;
    }
}