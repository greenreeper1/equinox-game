using UnityEngine;

[CreateAssetMenu(menuName = "Game/AugmentTypes/Damage")]
public class AugmentDamage : AugmentType
{
    public override void Apply(PlayerStatsRuntime stats, float value)
    {
        Debug.Log($"Damage before increase : {stats.damage}");
        stats.damage *= (1 + value);
        Debug.Log($"Damage after increase :  {stats.damage}");
    }
}
