using System;

public abstract class Base
{
    public string name = null ;

    public override string ToString() => $"{this.name} is a {this.GetType()}";

}

public interface IInteractive
{
    void Interact();
}

public interface IBreakable
{
    int durability { get; set; }

    void Break();
}

public interface ICollectable
{
    bool isCollected { get; set; }

    void Collect();
}

public class Door : Base, IInteractive
{
    public Door(string name = "Door") {
        this.name = name;
    }

    public void Interact() {
        Console.WriteLine($"You try to open the {this.name}. It's locked.");
    }
}

class Decoration : Base, IInteractive, IBreakable
{
    public int durability { get; set; }

    public bool isQuestItem;

    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false) {
        this.name = name;
        this.durability = durability > 0 ? durability : throw new Exception("Durability must be greater than 0");
        this.isQuestItem = isQuestItem;
    }

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