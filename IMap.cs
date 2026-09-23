namespace HS.Modding.SDK;

public interface IMap
{
    string Identifier { get; } // This is the prefix of mod and all its registered components, it looks like this (taken from what base-content will contain) "base:experiment_cube" or "base:plaza"
    string Name { get; }
    string Description { get; }

    string AssetName { get; } // You require this, as we primarily use assetbundles for mod assets (and base_content assets as well!)

    byte[] IconBytes { get; }
    string IconPath { get; }

    void OnRegister(IToolkit api);
    void OnLoaded(IToolkit api);
    void OnUnloaded(IToolkit api);
    void OnUnregister();
}