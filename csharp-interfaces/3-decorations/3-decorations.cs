using System;

/// <summary>
/// Base class for all game objects.
/// </summary>
public abstract class Base
{
    /// <summary>
    /// The name of the object.
    /// </summary>
    public string name = null ;

    /// <summary>
    /// Returns a string representation of the object.
    /// </summary>
    /// <returns>The string representation of the object.</returns>
    public override string ToString() => $"{this.name} is a {this.GetType()}";

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
    int durability { get; set; }

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
    /// Whether the object has been collected.
    /// </summary>
    bool isCollected { get; set; }

    /// <summary>
    /// Collects the object.
    /// </summary>
    void Collect();
}

/// <summary>
/// A door object.
/// </summary>
public class Door : Base, IInteractive
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Door"/> class.
    /// </summary>
    /// <param name="name">The name of the door. Default is "Door".</param>
    public Door(string name = "Door") {
        this.name = name;
    }

    /// <summary>
    /// Interacts with the door.
    /// </summary>
    public void Interact() {
        Console.WriteLine($"You try to open the {this.name}. It's locked.");
    }
}

/// <summary>
/// A decoration object.
/// </summary>
class Decoration : Base, IInteractive, IBreakable
{
    /// <summary>
    /// The durability of the decoration.
    /// </summary>
    public int durability { get; set; }

    /// <summary>
    /// Whether the decoration is a quest item.
    /// </summary>
    public bool isQuestItem;

    /// <summary>
    /// Initializes a new instance of the <see cref="Decoration"/> class.
    /// </summary>
    /// <param name="name">The name of the decoration. Default is "Decoration".</param>
    /// <param name="durability">The durability of the decoration. Default is 1.</param>
    /// <param name="isQuestItem">Whether the decoration is a quest item. Default is false.</param>
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false) {
        this.name = name;
        this.durability = durability > 0 ? durability : throw new Exception("Durability must be greater than 0");
        this.isQuestItem = isQuestItem;
    }

    /// <summary>
    /// Interacts with the decoration.
    /// </summary>
    public void Interact() {
        if(durability <= 0) {
            Console.WriteLine($"The {this.name} has been broken.");
        }
        else if (isQuestItem) {
            Console.WriteLine($"You look at the {this.name}. There's a key inside.");
        }
        else {
            Console.WriteLine($"You look at the {this.name}. Not much to see here.");
        }
    }

    /// <summary>
    /// Breaks the decoration.
    /// </summary>
    public void Break() {

        durability--;
        if(durability > 0) {
            Console.WriteLine($"You hit the {this.name}. It cracks.");
        }
        if (durability == 0) {
            Console.WriteLine($"You smash the {this.name}. What a mess.");
        } else if (durability < 0) {
            Console.WriteLine($"The {this.name} is already broken.");
        }
    }
}