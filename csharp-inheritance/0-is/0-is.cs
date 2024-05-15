using System;
/// <summary>
/// Contains a static method for checking if an object is of type int.
/// </summary>
public class obj
{
    /// <summary>
    /// Determines whether the given object is of type int.
    /// </summary>
    /// <param name="obj">The object to check.</param>
    /// <returns>True if the object is of type int, false otherwise.</returns>
    public static bool IsOfTypeInt(object obj)
    {
        if (obj is int)
            return true;
        else
            return false;
    }
}
