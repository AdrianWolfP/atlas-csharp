using System;

/// <summary>
/// An abstract base class for all derived classes to inherit from.
/// </summary>
public abstract class Base
{
    /// <summary>
    /// The name of the object.
    /// </summary>
    private string name = "";

    public override string ToString()
    {
        return $"{this.name} is a {this.GetType()}";
    }
}

public interface IInteractive
{
    void Interact();
}

public interface IBreakable
{
    int durabulity { get; set; }
    void Break();
}

public interface ICollectable
{
    bool isCollected { get; set; }
    void Collect();
}

public class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    public int durabulity { get; set; }
    public bool isCollected { get; set; }

    public void Interact()
    {

    }

    public void Break()
    {

    }

    public void Collect()
    {

    }
}