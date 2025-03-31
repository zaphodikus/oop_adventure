namespace OOPAdventure;

// All inventories will implement this interface, the inventory is
// managed using the translated item names of items.
public interface IInventory
{
    int Total { get; }
    public string[] InventoryList { get; }

    void Add(Item item);
    bool Contains(string itemName);
    Item? Find(string itemName);
    Item? Find(string itemName, bool remove);
    void Remove(Item item);
    Item? Take(string itemName);
    void Use(string itemName, string source);

}