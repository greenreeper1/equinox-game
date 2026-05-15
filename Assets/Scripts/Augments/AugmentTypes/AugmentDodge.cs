using UnityEngine;

[CreateAssetMenu(menuName = "Game/AugmentTypes/Dodge")]
public class AugmentDodge : AugmentType
{
    public override void Apply(PlayerStatsRuntime stats, float value)
    {
        Debug.Log($"Dodge chance before increase :  {stats.dodgeChance}");
        stats.dodgeChance += value;
        Debug.Log($"Dodge chance after increase :  {stats.dodgeChance}");
    }
}
