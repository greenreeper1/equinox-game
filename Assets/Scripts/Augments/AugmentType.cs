using UnityEngine;

public abstract class AugmentType : ScriptableObject
{
    public abstract void Apply(PlayerStatsRuntime stats, float value);
}
