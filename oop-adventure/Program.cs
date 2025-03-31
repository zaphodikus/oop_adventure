// a code-along exercise via linkedin learning, object-oriented-programming-with-c-sharp
// by Jesse Freeman.
// This is my manual input of the exercise code so names and comments
// vary somewhat.
using OOPAdventure;


//Object Oriented programming console app game
Text.LoadLanguage(new English());
Console.WriteLine(Text.Language.ChooseYourName);

var name = Console.ReadLine();
if (name == String.Empty)
    name = Text.Language.DefaultName;

var player = new Player(name);
Console.WriteLine(Text.Language.Welcome(player.Name));

var house = new House(player);
house.CreateRooms(3, 3);
house.DecorateRooms();
var items = new List<Item>()
{
    new Key(house),
    new Chest(new [] { new Gold(100)}, house)
};
house.PopulateRooms(items);

// register all valid actions
Actions.Instance.Register(new Go(house));
Actions.Instance.Register(new BackPack(player));
Actions.Instance.Register(new Take(house));
Actions.Instance.Register(new Use(house));
house.GoToStartingRoom();

var runLoop = true;
Room lastRoom = null;
while (runLoop)
{
    if (lastRoom != house.CurrentRoom)
    {
        Console.WriteLine(house.CurrentRoom.ToString());
        lastRoom = house.CurrentRoom;
    }
    Console.WriteLine(Text.Language.WhatToDo);
    var input = Console.ReadLine().ToLower();

    if (input == Text.Language.Quit)
        runLoop = false;
    else
        Actions.Instance.Execute(input.Split(" "));
}