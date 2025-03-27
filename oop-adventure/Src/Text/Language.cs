﻿
using OOPAdventure;

public abstract class Language
{
    public abstract string Welcome(string name);
    public string ChooseYourName{ get; protected set; } = "";
    public string DefaultName { get; protected set; } = "";
    public string DefaultRoomName { get; protected set; } = "";
    public string DefaultRoomDescription { get; protected set; } = "";

    // Actions
    public string ActionError { get; protected set; } = "";
    public string Go { get; protected set; } = "";
    public string GoError { get; protected set; } = "";

    // more...
    public string WhatToDo { get; protected set; } = "";
    public string Quit { get; protected set; } = "";


}