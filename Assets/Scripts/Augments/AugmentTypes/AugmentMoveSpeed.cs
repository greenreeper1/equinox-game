using UnityEngine;

public class AugmentMoveSpeed : AugmentType
{
    public override void Apply(PlayerData stats, float value)
    {
        Debug.Log($"Move speed before increase :  {stats.moveSpeed}");
        stats.moveSpeed *= (1 + value);
        Debug.Log($"Move speed after increase :  {stats.moveSpeed}");
    }
}
