using System;
using UnityEngine;

namespace HS.Modding.SDK;

public static class Events
{
    public delegate void GameUpdate(float dt);
    public static event GameUpdate OnTick;

    internal static void RaiseTick()
    {
        try
        {
            OnTick?.Invoke(Time.deltaTime);
        }
        catch (Exception ex)
        {
            Debug.Log("oh shittings");
        }
    }

    public delegate void OnConnect();
    public static event OnConnect OnConnection;

    internal static void RaiseConnection()
    {
        try
        {
            OnConnection?.Invoke();
        }
        catch (Exception ex)
        {
            Debug.Log("oh shittings");
        }
    }
    
    public delegate void OnLeave();
    public static event OnLeave OnDisconnect;

    internal static void RaiseDisconnection()
    {
        try
        {
            OnDisconnect?.Invoke();
        }
        catch (Exception ex)
        {
            Debug.Log("oh shittings");
        }
    }
}