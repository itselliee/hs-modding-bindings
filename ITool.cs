namespace HS.Modding.SDK;

/// <summary>
/// Question answering!!
/// Q: Where do I adjust the position of the gun in the users hand?
/// A: That's done in Horizon Sandbox, it should be configured before you export.
/// </summary>

public interface ITool
{
    string Identifier { get; } // This is the prefix of mod and all its registered components, it looks like this (taken from what base-content will contain) "base:experiment_cube" or "base:plaza"
    string Name { get; }
    string Description { get; }

    string AssetName { get; } // You require this, as we primarily use assetbundles for mod assets (and base_content assets as well!)

    byte[] IconBytes { get; }
    string IconPath { get; }

    void OnRegister(IToolkit api);
    void OnEquipped(IToolkit api);
    void OnUnequipped(IToolkit api);
    void OnUnregister();
}