using System;

namespace InventoryLibrary
{
    /// <summary>
    /// Represents an inventory item.
    /// </summary>
    /// <remarks>
    /// The `Inventory` class represents an inventory item, which consists of a user, an item, and a quantity.
    /// The `user` and `item` properties are instances of the `User` and `Item` classes, respectively, and the `quantity` property is an integer that represents the number of items in the inventory.
    /// The `user_id` and `item_id` properties are strings that represent the unique identifiers for the user and item, respectively.
    /// </remarks>
    public class Inventory : BaseClass
    {
        
        string_user_id = "";
        string_item_id = "";
        int _quantity = 1;

        /// <summary>
        /// Gets or sets the unique identifier for the user associated with the inventory item.
        /// </summary>
        /// <value>
        /// A string that represents the unique identifier for the user associated with the inventory item.
        /// </value>
        public string user_id
        {
            get { return _user_id; }
            set { _user_id = value; }
        }

        /// <summary>
        /// Gets or sets the unique identifier for the item associated with the inventory item.
        /// </summary>
        /// <value>
        /// A string that represents the unique identifier for the item associated with the inventory item.
        /// </value>
        public string item_id
        {
            get { return _item_id; }
            set { _item_id = value; }
        }

        /// <summary>
        /// Gets or sets the number of items in the inventory.
        /// </summary>
        /// <value>
        /// An integer that represents the number of items in the inventory.
        /// </value>
        public int quantity
        {
            get { return _quantity; }
            set { _quantity = Math.Max(value, 0); }
        }

        public Inventory(string user_id, string item_id, int quantity = 1)
        {
            this.user_id = user_id;
            this.item_id = item_id;
            this.quantity = quantity;
        }

        public Inventory(User user, Item item, int quantity = 1)
        {
            this.user_id = user.id;
            this.item_id = item.id;
            this.quantity = quantity;
        }
    }
} using System.Text.Json;

public class Inventory : BaseClass
{
    public User user { get; set; }
    public Item item { get; set; }
    public int quantity { get; set; }
    public string user_id { get; set; }
    public string item_id { get; set; }

    /// <summary>
    /// Initializes a new instance of the `Inventory` class with the specified user, item, and quantity.
    /// </summary>
    /// <param name="user">The user associated with the inventory item. This can be null, in which case the `user_id` property will be set to "Default_Item_Id".</param>
    /// <param name="item">The item associated with the inventory item. This can be null, in which case the `item_id` property will be set to "Default_Item_Id".</param>
    /// <param name="quantity">The number of items in the inventory. This must be a positive integer. If it is not, the `quantity` property will be set to 1.</param>
    public Inventory(User user = null, Item item = null, int quantity = 1)
    {
        if (quantity < 0)
            quantity = 1;

        this.quantity = quantity;
        if (user != null)
            this.user_id = user.id;
        else
            this.user_id = "Default_Item_Id";
        if (item != null)
            this.item_id = item.id;
        else
            this.item_id = "Default_Item_Id";
    }

    /// <summary>
    /// Returns a string that represents the current `Inventory` object.
    /// </summary>
    /// <returns>
    /// A string that represents the current `Inventory` object.
    /// </returns>
    public override string ToString()
    {
        string returnValue = $"Object: {this.GetType().Name}\nOwn Id: {this.id}\nUser Id: {this.user_id}\nItem Id: {this.item_id}\nItem Quiantity: {this.quantity}\nCreation Date: {this.date_created}\nUpdated Date: {this.date_updated}";
        return (returnValue);
    }
}