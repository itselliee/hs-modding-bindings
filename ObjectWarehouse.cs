namespace HS.Modding.SDK;

// ObjectWarehouse applies to everyone.
public interface ObjectWarehouse
{
    void RegisterObjects(IObject obj);
    void UnregisterObjects(IObject obj);

    void RegisterMaps(IMap map);
    void UnregisterMaps(IMap map);

    void RegisterTool(ITool tool);
    void UnregisterTool(ITool tool);
}