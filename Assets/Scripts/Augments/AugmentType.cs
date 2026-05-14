using UnityEngine;

public abstract class AugmentType : ScriptableObject
{
    public abstract void Apply(PlayerData stats, float value);
}
