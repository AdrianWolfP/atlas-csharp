using System;

/// <summary>
/// Class representing a shape with an area
/// </summary>
public class Shape
{
    /// <summary>
    /// Calculates the area of the shape
    /// </summary>
    /// <returns>The area of the shape</returns>
    /// /// <exception cref="NotImplementedException">Thrown if the Area() method is not implemented in a derived class.</exception>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

/// <summary>
/// Class representing a rectangle with a width and a height.
/// </summary>
public class Rectangle : Shape
{
    /// <summary>
    /// The width of the rectangle
    /// </summary>
    private int width;
    private int height;

    /// <summary>
    /// Gets or sets the width of the rectangle.
    /// </summary>
    /// <value>The width of the rectangle.</value>
    /// <exception cref="ArgumentException">Thrown if the width is less than 0.</exception>
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
    /// <exception cref="ArgumentException">Thrown if the height is less than 0.</exception>
    public int Height
    {
        get { return height; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Height must be greater than or equal to 0");
            else
                height = value;
        }
    }
}