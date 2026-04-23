using UnityEngine;

public class AugmentHP : AugmentType
{
    public override void Apply(PlayerData stats, float value)
    {
        Debug.Log($"Health before increase :  {stats.health}");
        stats.health *= (1 + value);
        Debug.Log($"Health after increase :  {stats.health}");
    }
}
