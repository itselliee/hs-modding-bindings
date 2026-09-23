namespace HS.Modding.SDK;

public abstract class BaseMap
{
    public abstract string Identifier { get; }
    public abstract string Name { get; }
    public abstract string Description { get; }
    
    public abstract string IconPath { get; }
    public abstract string AssetPath { get; }

    public abstract void OnRegistration();
    public abstract void OnUnregistration();

    public virtual void OnLoad() { }
    public virtual void OnUnload() { }
}