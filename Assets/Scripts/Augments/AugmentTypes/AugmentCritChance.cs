using UnityEngine;

public class AugmentCritChance : AugmentType
{
    public override void Apply(PlayerData stats, float value)
    {
        Debug.Log($"Critical chance before increase :  {stats.criticalChance}");
        stats.criticalChance += value;
        Debug.Log($"Critical chance after increase :  {stats.criticalChance}");
    }
}
