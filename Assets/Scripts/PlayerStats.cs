using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public PlayerData baseData;

    public PlayerStatsRuntime runtimeData;

    void Awake()
    {
        runtimeData = new PlayerStatsRuntime(baseData);
    }
}
