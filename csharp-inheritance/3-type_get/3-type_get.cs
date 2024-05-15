using System;
using System.Reflection;

/// <summary>
/// Provides a static method for printing the properties and methods of an object to the console.
/// </summary>
public class Obj
{
    /// <summary>
    /// Prints the properties and methods of the given object to the console.
    /// </summary>
    /// <param name="myObj">The object to print the properties and methods of.</param>
    public static void Print(object myObj)
    {
        TypeInfo typeInfo = myObj.GetType().GetTypeInfo();

        Console.WriteLine($"{typeInfo.Name} Properties:");

        foreach (PropertyInfo prop in typeInfo.GetProperties())
        {
            Console.WriteLine(prop.Name);
        }

        Console.WriteLine($"{typeInfo.Name} Methods:");

        foreach (MethodInfo method in typeInfo.GetMethods())
        {
            Console.WriteLine(method.Name);
        }
    }
}