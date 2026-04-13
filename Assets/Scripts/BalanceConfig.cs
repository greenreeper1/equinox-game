using UnityEngine;

[CreateAssetMenu(fileName = "BalanceConfig", menuName = "Roguelike/BalanceConfig")]
public class BalanceConfig : ScriptableObject
{
    public float armorK = 50f; // Higher means more armor is needed to reduce damage by 50%
}
