using UnityEngine;

[CreateAssetMenu(menuName = "Game/AugmentTypes/Armor")]
public class AugmentArmor : AugmentType
{
    public override void Apply(PlayerStatsRuntime stats, float value)
    {
        Debug.Log($"Armor before increase :  {stats.armor}");
        stats.armor += value;
        Debug.Log($"Armor after increase :  {stats.armor}");
    }
}
