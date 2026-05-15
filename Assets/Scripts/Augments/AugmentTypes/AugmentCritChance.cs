using UnityEngine;

[CreateAssetMenu(menuName = "Game/AugmentTypes/CritChance")]
public class AugmentCritChance : AugmentType
{
    public override void Apply(PlayerStatsRuntime stats, float value)
    {
        Debug.Log($"Critical chance before increase :  {stats.criticalChance}");
        stats.criticalChance += value;
        Debug.Log($"Critical chance after increase :  {stats.criticalChance}");
    }
}
