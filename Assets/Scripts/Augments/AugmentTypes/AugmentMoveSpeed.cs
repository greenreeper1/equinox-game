using UnityEngine;

[CreateAssetMenu(menuName = "Game/AugmentTypes/MoveSpeed")]
public class AugmentMoveSpeed : AugmentType
{
    public override void Apply(PlayerStatsRuntime stats, float value)
    {
        Debug.Log($"Move speed before increase :  {stats.moveSpeed}");
        stats.moveSpeed *= (1 + value);
        Debug.Log($"Move speed after increase :  {stats.moveSpeed}");
    }
}
