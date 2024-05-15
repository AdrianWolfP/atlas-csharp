using System;

/// <summary>
/// Contains a static method for checking if a given type is a direct or indirect subclass of a base type.
/// </summary>
public static class Obj
{
    /// <summary>
    /// Determines whether the given derived type is a subclass of the base type.
    /// </summary>
    /// <param name="derivedType">The type that may derive from the base type.</param>
    /// <param name="baseType">The base type to check against.</param>
    /// <returns>True if the derived type is a subclass of the base type, false otherwise.</returns>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        return derivedType.IsSubclassOf(baseType);
    }
}