﻿namespace OOPAdventure;

public abstract class Item
{
    public virtual string Name { get; set; }

    public bool SingleUse { get; set; }
    public bool CanTake { get; set; }

    public virtual void Use(string source)
    {
        throw new NotImplementedException();
    }
}