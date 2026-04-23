using UnityEngine;

public class AugmentAttackSpeed : AugmentType
{
    public override void Apply(PlayerData stats, float value)
    {
        Debug.Log($"Attack peed before increase :  {stats.attackSpeed}");
        stats.attackSpeed *= (1 + value);
        Debug.Log($"Attack speed after increase :  {stats.attackSpeed}");
    }
}
