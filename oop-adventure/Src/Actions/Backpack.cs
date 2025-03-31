namespace OOPAdventure;

public class BackPack : Action
{
    public override string Name => Text.Language.BackPack;
    private readonly IInventory _inventory;

    public BackPack(IInventory inventory)
    {
        _inventory = inventory;
    }

    // Action
    public override void Execute(string[] args)
    {
        var items = _inventory.InventoryList;
        if (items.Length == 0)
        {
            Console.WriteLine(Text.Language.BackPackError);
        }
        else
        {
            var list = Text.Language.JoinedWordList(items, Text.Language.And);
            Console.WriteLine(Text.Language.BackpackDescription, list);
        }
    }
}