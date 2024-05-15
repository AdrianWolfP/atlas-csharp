using System;

/// <summary>
/// Base class for all shapes.
/// </summary>
public class Shape
{
    
    /// <summary>
    /// Gets the area of the shape.
    /// </summary>
    /// <returns>The area of the shape.</returns>
    /// <remarks>This method throws a <see cref="NotImplementedException"/> if called, as it is intended to be overridden by derived classes.</remarks>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}