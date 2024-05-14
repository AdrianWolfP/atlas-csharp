using System;

public class obj
{
    public static bool IsOfTypeInt(object obj)
    {
        if (obj is int)
            return true;
        else
            return false;
    }
}
