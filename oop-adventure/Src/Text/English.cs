
namespace OOPAdventure.English;

public class English :Language
{
    public English()
    {
        ChooseYourName = "Hello, what is your name?";
        DefaultName = "No-name";
        DefaultRoomName = "Room {0} ({1},{2})";
        DefaultRoomDescription = "You are in a room with doors to the {}.";
        ActionError = "You cannot do that now.";
        Go = "Go";
        GoError = "Cannot go that way.";
        WhatToDo = "What do you want to do?";
        Quit = "quit";
    }

    public override string Welcome(string name) 
    {
    return $"Welcome {name} to your OOP adventure";
    }
    
}