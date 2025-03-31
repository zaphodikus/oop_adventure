﻿namespace OOPAdventure;

class Chest : Item, IInventory
{

    private readonly House _house; // so we can find the player
    private readonly Inventory _inventory = new();
    public override string Name => Text.Language.Chest;
    public bool Locked = true;
    
    public Chest(Item?[] items, House house)
    {
        CanTake = false; // Ensure the chest cannot be 'taken' or picked up
        _house = house;
        // copy the items
        foreach(var item in items)
        {
            Add(item);
        }
    }

    public override void Use(string source)
    {
        if (source == Text.Language.Key)
        {
            var items = InventoryList;
            if (Locked)
                Console.WriteLine(Text.Language.UnlockChest);
            if (items.Length == 0)  // empty
            {
                Console.WriteLine(Text.Language.ChestEmpty);
            }
            else
            {
                Console.WriteLine(string.Format(Text.Language.ChestFound, 
                                  Text.Language.JoinedWordList(items, Text.Language.And)));
                foreach(var itemName in items)
                {
                    var item = Take(itemName);
                    _house.Player.Add(item);
                }
            }
        }
    }

    // Inventory implementation
    public int Total => ((IInventory)_inventory).Total;

    public string[] InventoryList => ((IInventory)_inventory).InventoryList;

    public void Add(Item item)
    {
        ((IInventory)_inventory).Add(item);
    }

    public bool Contains(string itemName)
    {
        return ((IInventory)_inventory).Contains(itemName);
    }

    public Item? Find(string itemName)
    {
        return ((IInventory)_inventory).Find(itemName);
    }

    public Item? Find(string itemName, bool remove)
    {
        return ((IInventory)_inventory).Find(itemName, remove);
    }

    public void Remove(Item item)
    {
        ((IInventory)_inventory).Remove(item);
    }

    public Item? Take(string itemName)
    {
        return ((IInventory)_inventory).Take(itemName);
    }

    public void Use(string itemName, string source)
    {
        ((IInventory)_inventory).Use(itemName, source);
    }
}