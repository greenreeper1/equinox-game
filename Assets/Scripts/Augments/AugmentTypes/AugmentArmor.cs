using UnityEngine;

public class AugmentArmor : AugmentType
{
    public override void Apply(PlayerData stats, float value)
    {
        Debug.Log($"Armor before increase :  {stats.armor}");
        stats.armor += value;
        Debug.Log($"Armor after increase :  {stats.armor}");
    }
}
