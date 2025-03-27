namespace OOPAdventure;

public abstract class Action
{
    // name of an action. This setter sets the action to be empty so we must override it in each class
    public virtual string Name => ""; 

    public virtual void Execute(string[] args)
    {
        // caller should override
        throw new Exception("No way to execute that!");
    }
}