using System;

/// <summary>
/// This is the base class for all objects in the InventoryLibrary namespace.
/// </summary>
/// <remarks>
/// This class provides a common set of properties for all objects in the InventoryLibrary namespace.
/// Each object should have a unique identifier (`id`), a creation date (`date_created`),
/// and an updated date (`date_updated`).
/// </remarks>
namespace InventoryLibrary
{
    public class BaseClass
    {
        /// <summary>
        /// The unique identifier for the object.
        /// </summary>
        public string id {get; set;}
        /// <summary>
        /// The date and time the object was created.
        /// </summary>
        public DateTime date_created {get; set;}
        /// <summary>
        /// The date and time the object was last updated.
        /// </summary>
        public DateTime date_updated {get; set;}
    }
}