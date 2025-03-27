﻿
namespace OOPAdventure;

public class English :Language
{
    public English()
    {
        ChooseYourName = "Hello, what is your name?";
        DefaultName = "No-name";
        DefaultRoomName = "Room {0} ({1},{2})";
        DefaultRoomDescription = " You are in a {0} room with doors to the {1}.";
        ActionError = "You cannot do that now.";
        Go = "Go";
        GoError = "Cannot go that way.";
        WhatToDo = "What do you want to do?";
        Quit = "quit";
        RoomNew = "You entered {0}.";
        RoomOld = "You return to {}.";
        And = "and"; // joining word 
        Comma = ",";
        Space = " ";
        RoomDescriptions = new List<string>
            { "normal", // 50% chance we choose this description, else one of the others
                "cold",
                "warm",
                "dark",
                "bright",
                "scary",
                "strange"
        };
        NoItem = "You don't have {0}.";
        BackPack = "backpack";
        BackPackError = "You don't have anything in your backpack.";
        BackpackDescription = "Your backpack contains : {0}.";
    }

    public override string Welcome(string name) 
    {
    return $"Welcome {name} to your OOP adventure";
    }
    
}