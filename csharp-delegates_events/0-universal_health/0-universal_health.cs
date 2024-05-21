using System;

/// <summary>
/// This class represents a player in a game.
/// </summary>
/// <remarks>
/// This class contains information about a player, such as their name, maximum health points (HP), and current HP.
/// The default name is "Player" and the default maximum HP is 100.
/// </remarks>
public class Player
{
    /// <summary>
    /// The name of the player.
    /// </summary>
    /// <remarks>
    /// The default name is "Player".
    /// </remarks>
    protected string name;

    /// <summary>
    /// The maximum health points (HP) of the player.
    /// </summary>
    /// <remarks>
    /// The default maximum HP is 100.
    /// </remarks>
    protected float maxHp;

    /// <summary>
    /// The current health points (HP) of the player.
    /// </summary>
    /// <remarks>
    /// The default current HP is equal to the maximum HP.
    /// </remarks>
    protected float hp;

    /// <summary>
    /// Initializes a new instance of the <see cref="Player"/> class.
    /// </summary>
    /// <param name="name">The name of the player. The default value is "Player".</param>
    /// <param name="maxHp">The maximum HP of the player. The default value is 100.</param>
    /// <remarks>
    /// If the maximum HP is less than or equal to 0, it is set to 100 by default.
    /// </remarks>
    public Player(string name="Player", float maxHp=100f)
    {
       this.name = name;
       if (maxHp <= 0f) {
        Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        maxHp = 100f;
       }
       this.maxHp = maxHp;
       this.hp = this.maxHp;
    }

    /// <summary>
    /// Prints the current HP and maximum HP of the player.
    /// </summary>
    /// <remarks>
    /// This method prints a message to the console indicating the current HP and maximum HP of the player.
    /// </remarks>
    public void PrintHealth()
    {
        Console.WriteLine("{0} has {1} / {2} health", name, hp, maxHp);
    }
}