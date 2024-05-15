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

/// <summary>
/// A class representing a rectangle, which inherits from the Shape class.
/// </summary>
public class Rectangle : Shape
{
    private int width;
    private int height;

    /// <summary>
    /// Gets or sets the width of the rectangle.
    /// </summary>
    /// <value>The width of the rectangle.</value>
    /// <remarks>The width must be greater than or equal to 0.</remarks>
    public int Width
    {
        get { return width; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Width must be greater than or equal to 0");
            else
                width = value;
        }
    }

    /// <summary>
    /// Gets or sets the height of the rectangle.
    /// </summary>
    /// <value>The height of the rectangle.</value>
    /// <remarks>The height must be greater than or equal to 0.</remarks>
    public int Height
    {
        get { return height; }
        set
        {
            if (value < 0)
                throw new  ArgumentException("Height must be greater than or equal to 0");
            else
                height = value;
        }
    }

    /// <summary>
    /// Gets the area of the rectangle.
    /// </summary>
    /// <returns>The area of the rectangle.</returns>
    /// <remarks>Overrides the <see cref="Shape.Area()"/> method.</remarks>
    public new int Area()
    {
        return height * width;
    }

    /// <summary>
    /// Gets a string representation of the rectangle.
    /// </summary>
    /// <returns>A string representation of the rectangle.</returns>
    public override string ToString()
    {
        return $[{this.GetType().Name}] {width} / {height}";
    }
}

public class Square : Rectangle
{
    private int size;

    public int size
    {
        get { return size; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Size must be greater than or equal to 0");

            size = value;
            Height = value;
            Width = value;
        }
    }
}