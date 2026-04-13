using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "Roguelike/PlayerData")]
public class PlayerData : ScriptableObject
{
    public float health = 100f;
    public float damage = 10f;
    public float armor = 0f;
    public float moveSpeed = 5f;
    public float attackSpeed = 1f;
    public float dodgeChance = 0f;
    public float criticalChance = 0f;
    public float lifesteal = 0f;
}
