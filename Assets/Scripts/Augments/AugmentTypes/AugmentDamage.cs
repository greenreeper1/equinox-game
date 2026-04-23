using UnityEngine;

public class AugmentDamage : AugmentType
{
    public override void Apply(PlayerData stats, float value)
    {
        Debug.Log($"Damage before increase : {stats.damage}");
        stats.damage *= (1 + value);
        Debug.Log($"Damage after increase :  {stats.damage}");
    }
}
