using System;

/// <summary>
/// An abstract base class for all derived classes to inherit from.
/// </summary>
public abstract class Base
{
    /// <summary>
    /// The name of the object.
    /// </summary>
    public string name = "";

        /// <summary>
    /// Returns a string representation of the object.
    /// </summary>
    /// <returns>A string in the format "name is a TypeName"</returns>
        public override string ToString()
        {
            return $"{this.name} is a {this.GetType()}";
        }
}

/// <summary>
/// Interface for objects that can be interacted with.
/// </summary>
public interface IInteractive
{
    /// <summary>
    /// Interacts with the object.
    /// </summary>
    void Interact();
}

/// <summary>
/// Interface for objects that can be broken.
/// </summary>
public interface IBreakable
{
    /// <summary>
    /// The durability of the object.
    /// </summary>
    int durabulity{ get; set; }

    /// <summary>
    /// Breaks the object.
    /// </summary>
    void Break();
}

/// <summary>
/// Interface for objects that can be collected.
/// </summary>
public interface ICollectable
{
    /// <summary>
    /// Indicates whether the object has been collected.
    /// </summary>
    bool isCollected { get; set; }

    /// <summary>
    /// Collects the object.
    /// </summary>
    void Collect();
}

/// <summary>
/// A door object that can be interacted with.
/// </summary>
public class Door : Base, IInteractive
{
    /// <summary>
    /// Initializes a new instance of the Door class with an optional name.
    /// </summary>
    /// <param name="name">The name of the door (default is "Door").</param>
    public Door(string name = "Door")
    {
        this.name = name;
    }

    /// <summary>
    /// Interacts with the door.
    /// </summary>
    public void Interact()
    {
        Console.WriteLine($"You try to open the {this.name}. It's locked.");
    }
}