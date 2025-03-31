namespace OOPAdventure;

public class Use : Action
{
    public override string Name => Text.Language.Use;

    private readonly House _house;

    public Use(House house)
    {
        _house = house;
    }

    public override void Execute(string[] args)
    {
        if (args.Length == 1)
        {
            Console.WriteLine(Text.Language.UseError);
            return;
        }
        var itemName = args[1].ToLower();
        if (_house.Player.Contains(itemName))
        {
            var item = _house.Player.Take(itemName);
            Console.WriteLine(Text.Language.UseSuccess, item.Name);

            item.Use(itemName);
        }
        else
        {
            Console.WriteLine(Text.Language.UseError);
        }
    }
}