namespace OOPAdventure;

class Key : Item 
{
    private readonly House _house;
    public override string Name => Text.Language.Key;
    public Key(House house)
    {
        _house = house;
        CanTake = true;
        SingleUse = true; // removed when used
    }

    public override void Use(string source)
    {
        _house.CurrentRoom.Use(Text.Language.Chest, Name); // "use key on chest"
    }
}