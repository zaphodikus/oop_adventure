
using System.Text;

namespace OOPAdventure;

public class Room
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
}