namespace HS.Modding.SDK;

public abstract class BaseMod
{
    public abstract string Identifier { get; }
    public abstract string Name { get; }
    public abstract string Author { get; }
    public abstract string Version { get; }
    public abstract string Description { get; }
    public abstract string[] Dependencies { get; }
    
    public abstract string IconPath { get; }

    public abstract void OnRegistration();
    public abstract void OnUnregistration();
}