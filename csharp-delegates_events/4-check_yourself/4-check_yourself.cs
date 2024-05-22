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
    /// This event is triggered when the player's HP changes.
    /// </summary>
    public delegate void CalculateHealth(float amount);

    /// <summary>
    /// Represents an event that is raised when the current HP value of an object changes.
    /// </summary>
    /// <param name="sender">The object that raised the event.</param>
    /// <param name="e">An instance of the `CurrentHPArgs` class that contains the current HP value.</param>
    public EventHandler<CurrentHPArgs> HPCheck;

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
       this.status = String.Format("{0} is ready to go!", name);
       HPCheck += CheckStatus;
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
    
    /// <summary>
    /// This method applies damage to the player's HP.
    /// </summary>
    /// <param name="damage">The amount of damage to apply to the player's HP.</param>
    /// <remarks>
    /// This method applies the given amount of damage to the player's HP.
    /// If the damage is less than 0, it is set to 0.
    /// A message is printed to the console indicating the amount of damage taken.
    /// </remarks>
    public void TakeDamage(float damage)
    {
        if (damage < 0f)
            damage = 0f;
        Console.WriteLine("{0} takes {1} damage!", name, damage);
        ValidateHP(hp - damage);
    }

    /// <summary>
    /// This method heals the player's HP.
    /// </summary>
    /// <param name="heal">The amount of HP to heal.</param>
    /// <remarks>
    /// This method applies the given amount of HP to the player's HP.
    /// If the heal amount is less than 0, it is set to 0.
    /// A message is printed to the console indicating the amount of HP healed.
    /// </remarks>
    public void HealDamage(float heal)
    {
        if( heal < 0f)
            heal = 0f;
        Console.WriteLine("{0} heals {1} HP!", name, heal);
        ValidateHP(hp + heal);
    }

    /// <summary>
    /// Validates the new hit points value and sets the `hp` property accordingly.
    /// </summary>
    /// <param name="newHp">The new hit points value to validate.</param>
    /// <remarks>
    /// This method ensures that the `hp` property is always within the valid range (0 to `maxHp`).
    /// If the `newHp` value is less than 0, the `hp` property is set to 0.
    /// If the `newHp` value is greater than `maxHp`, the `hp` property is set to `maxHp`.
    /// </remarks>
    public void ValidateHP(float newHp)
    {
        hp = Math.Clamp(newHp, 0, maxHp);
        HPCheck(this, new CurrentHPArgs(this.hp));
    }

    /// <summary>
    /// Applies a modifier to a base value and returns the result.
    /// </summary>
    /// <param name="baseValue">The base value to apply the modifier to.</param>
    /// <param name="modifier">The modifier to apply to the base value.</param>
    /// <returns>The base value modified by the specified modifier.</returns>
    /// <remarks>
    /// This method applies a multiplicative modifier to the base value.
    /// The `Modifier` enum defines the available modifiers: `Weak`, `Base`, and `Strong`.
    /// The `Weak` modifier reduces the base value by 50%, the `Base` modifier leaves the base value unchanged, and the `Strong` modifier increases the base value by 50%.
    /// </remarks>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if (modifier == Modifier.Weak)
            return baseValue * 0.5f;
        else if (modifier == Modifier.Strong)
            return baseValue * 1.5f;
        else
            return baseValue;
    }

    /// <summary>
    /// Checks the status of an object based on its current HP value.
    /// </summary>
    /// <param name="sender">The object that raised the `HPCheck` event.</param>
    /// <param name="e">An instance of the `CurrentHPArgs` class that contains the current HP value.</param>
    /// <remarks>
    /// This method calculates the current status of an object based on its current HP value as a percentage of its maximum HP value.
    /// The status is determined using the following rules:
    /// - If the current HP value is equal to the maximum HP value, the status is "perfect health".
    /// - If the current HP value is greater than or equal to 50% of the maximum HP value, the status is "doing well".
    /// - If the current HP value is greater than or equal to 25% of the maximum HP value, the status is "isn't doing too great".
    /// - If the current HP value is greater than 0, the status is "needs help".
    /// - If the current HP value is 0, the status is "is knocked out".
    /// </remarks>
    public void CheckStatus(object sender, CurrentHPArgs e)
    {
        float state = e.currentHp/maxHp;
        if (state == 1)
            status = String.Format("{0} is in perfect health!", name);
        else if (state >= 0.5f)
            status = String.Format("{0} is doing well", name);
        else if (state >= 0.25f)
            status = String.Format("{0} isn't doing too great...", name);
        else if (state > 0f)
            status = String.Format("{0} needs help!", name);
        else
            status = String.Format("{0} is knocked out!", name);
    

        Console.WriteLine(status);
    }
}
/// <summary>
/// Defines the available modifiers for the `ApplyModifier` method.
/// </summary>
public enum Modifier
{
    /// <summary>
    /// Reduces the base value by 50%.
    /// </summary>
    Weak,

    /// <summary>
    /// Leaves the base value unchanged.
    /// </summary>
    Base,

    /// <summary>
    /// Increases the base value by 50%.
    /// </summary>
    Strong
}

/// <summary>
/// Defines a delegate for calculating a modifier for a base value.
/// </summary>
/// <param name="baseValue">The base value to apply the modifier to.</param>
/// <param name="modifier">The modifier to apply to the base value.</param>
/// <returns>The base value modified by the specified modifier.</returns>
/// <remarks>
/// This delegate is used to define custom modifier calculation methods that can be passed to the `ApplyModifier` method.
/// The `Modifier` enum defines the available modifiers: `Weak`, `Base`, and `Strong`.
/// The `CalculateModifier` delegate should return the base value modified by the specified modifier.
/// </remarks>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

/// <summary>
/// Defines a class that contains the current HP value for an event argument.
/// </summary>
/// <remarks>
/// This class is used as an event argument for the `HPCheck` event.
/// It contains a single property, `currentHp`, which represents the current HP value.
/// </remarks>
public class CurrentHPArgs: EventArgs
{
    /// <summary>
    /// Gets the current HP value.
    /// </summary>
    /// <value>
    /// The current HP value.
    /// </value>
    public float currentHp {get;}

    /// <summary>
    /// Initializes a new instance of the `CurrentHPArgs` class with the specified current HP value.
    /// </summary>
    /// <param name="newHp">The new current HP value.</param>
    public CurrentHPArgs(float newHp)
    {
        this.currentHp = newHp;
    }
}  