namespace HS.Modding.SDK;

public interface IObject
{
    string Identifier { get; } // This is the prefix of mod and all its registered components, it looks like this (taken from what base-content will contain) "base:experiment_cube" or "base:plaza"
    string Name { get; }
    string Description { get; }
    ObjectCategory Category { get; }

    string AssetName { get; } // You require this, as we primarily use assetbundles for mod assets (and base_content assets as well!)

    byte[] IconBytes { get; }
    string IconPath { get; }

    void OnRegister(IToolkit api);
    
    // == These are when you're in a game, and they won't sync for other clients. == //
    void OnSpawned(IToolkit api); 
    void OnDespawned(IToolkit api);
    // == == == == == == == == == == == == == == == == == == == == == == == == == == //
    
    void OnUnregister();
}