using UnityEngine;

public class AugmentDodge : AugmentType
{
    public override void Apply(PlayerData stats, float value)
    {
        Debug.Log($"Dodge chance before increase :  {stats.dodgeChance}");
        stats.dodgeChance += value;
        Debug.Log($"Dodge chance after increase :  {stats.dodgeChance}");
    }
}
