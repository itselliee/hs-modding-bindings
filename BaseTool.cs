namespace HS.Modding.SDK;

public abstract class BaseTool
{
    public abstract string Identifier { get; }
    public abstract string Name { get; }
    public abstract string Description { get; }
    public abstract string Category { get; }
    
    public abstract string IconPath { get; }
    public abstract string AssetPath { get; }

    public abstract void OnRegistration();
    public abstract void OnUnregistration();

    public virtual void OnUsed() { }
    public virtual void OnRelease() { }
}