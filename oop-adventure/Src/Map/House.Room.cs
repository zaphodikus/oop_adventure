namespace OOPAdventure;

public partial class House
{
    private int CalculateRoomIndex(int col, int row)
    {
        return Math.Clamp(col, -1, Width) + Math.Clamp(row, -1, Height) * Width;
    }

    public void CreateRooms(int width, int height)
    {
        // minimum 2 wide max 10 wide
        Width = Math.Clamp(width, 2, 10);
        Height = Math.Clamp(height, 2, 10);

        var total = Width * Height;

        Rooms = new Room[total];
        for (var i = 0; i < total; i++)
        {
            var room = new Room();
            var col = i % Width;
            var row = i / Width;
            room.Name = String.Format(Text.Language.DefaultRoomName, i, col, row);

            if (col < Width - 1) // there is a room to the east
                room.Neighbours[Directions.East] = CalculateRoomIndex(col + 1, row);
            if (col > 0) // there is a room to the west
                room.Neighbours[Directions.West] = CalculateRoomIndex(col - 1, row);
            if (row < Height - 1)
                room.Neighbours[Directions.South] = CalculateRoomIndex(col, row + 1);
            if (row > 0)
                room.Neighbours[Directions.North] = CalculateRoomIndex(col, row - 1);

            Rooms[i] = room;
        }
    }
}