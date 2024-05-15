using System;

public static class Obj
{
    public static bool IsOnlyASubClass(Type derivedType, Type baseType)
    {
        return derivedType.IsSubclassOf(baseType);
    }
}