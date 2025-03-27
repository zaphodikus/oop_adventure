
using System.Text;

namespace OOPAdventure;

public class Room : IInventory
{
    public string Name { get; set; } = Text.Language.DefaultRoomName;
    public string Description { get; set; } = Text.Language.DefaultRoomDescription;

    public Dictionary<Directions, int> Neighbours { get; set; } = new()
    {
        {Directions.North, -1 },
        {Directions.South, -1 },
        {Directions.East, -1 },
        {Directions.West, -1 },
        {Directions.None, -1}
    };

    public bool Visited { get; set; }


    public override string ToString()
    {
        var sb = new StringBuilder();
        if (Visited)
            sb.Append(String.Format(Text.Language.RoomOld, Name));
        else
            sb.Append(String.Format(Text.Language.RoomNew, Name));

        var names = Enum.GetNames(typeof(Directions));
        // -1 is our special value that says there is no door
        var directions = (from p in names where Neighbours[(Directions)Enum.Parse(typeof(Directions), p)] > -1 select p.ToLower()).ToArray();

        var description = String.Format(Text.Language.JoinedWordList(directions, Text.Language.And));
        sb.Append(description);
        return sb.ToString();
    }

    // Inventory for a room
    public int Total => _inventory.Total;

    public string[] InventoryList => _inventory.InventoryList;

    public void Add(Item item)
    {
        _inventory.Add(item);
    }

    public bool Contains(string itemName)
    {
        return _inventory.Contains(itemName);
    }

    public Item? Find(string itemName)
    {
        return _inventory.Find(itemName);
    }

    public Item? Find(string itemName, bool remove)
    {
        return _inventory.Find(itemName, remove);
    }

    public void Remove(Item item)
    {
        _inventory.Remove(item);
    }

    public Item? Take(string itemName)
    {
        return _inventory.Take(itemName);
    }

    public void Use(string itemName, string source)
    {
        _inventory.Use(itemName, source);
    }

    // Inventory of the room
    private readonly IInventory _inventory = new Inventory();
}