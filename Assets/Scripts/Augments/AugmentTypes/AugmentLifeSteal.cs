using UnityEngine;

public class AugmentLifeSteal : AugmentType
{
    public override void Apply(PlayerData stats, float value)
    {
        Debug.Log($"Lifesteal before increase :  {stats.lifesteal}");
        stats.lifesteal += value;
        Debug.Log($"Lifesteal after increase :  {stats.lifesteal}");
    }
}
