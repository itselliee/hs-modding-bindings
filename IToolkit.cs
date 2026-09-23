namespace HS.Modding.SDK;

public interface IToolkit
{
    ObjectWarehouse ObjectWarehouse { get; }
    T LoadAsset<T>(string relativePath) where T : UnityEngine.Object;
}