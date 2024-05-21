using System;

/// <summary>
/// This class represents an item in the inventory.
/// </summary>
/// <remarks>
/// This class inherits from the `BaseClass` class and provides additional properties specific to an item.
/// Each item should have a name (`name`), a description (`description`), and a price (`price`).
/// </remarks>
namespace InventoryLibrary

public class Item: BaseClass
{
    /// <summary>
    /// The name of the item.
    /// </summary>
    public string name {get; set;}
    
    /// <summary>
    /// The description of the item.
    /// </summary>
    public string description {get; set;}
    
    /// <summary>
    /// The price of the item.
    /// </summary>
    public float price {get; set;}

    /// <summary>
    /// Initializes a new instance of the `Item` class.
    /// </summary>
    /// <param name="name">The name of the item. Default value is "Default\_Item\_Name".</param>
    /// <param name="description">The description of the item. Default value is "Default\_Item\_Description".</param>
    /// <param name="price">The price of the item. Default value is 0.0f.</param>
    public Item(string name = "Default_Item_Name", string description = "Default_Item_Description", float price = 0.0f)
    {
        this.name = name;
        this.description = description;
        this.price = Convert.ToString(Math.Round(price, 2));
    }

    /// <summary>
    /// Returns a string representation of the item.
    /// </summary>
    /// <returns>A string containing the item's properties and their values.</returns>
    public override string ToString()
    {
        string returnValue = $"Object: {this.GetType().Name}\nName: {this.name}\nId: {this.id}\nDescription: {this.description}\nPrice: {this.price}\nCreation Date: {this.date_created}\nUpdated Date: {this.date_updated}";
        return (returnValue);
    }
}