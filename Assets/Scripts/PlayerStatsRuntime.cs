using UnityEngine;

[System.Serializable]
public class PlayerStatsRuntime : MonoBehaviour
{
    public float health;
    public float damage;
    public float armor;
    public float moveSpeed;
    public float attackSpeed;
    public float dodgeChance;
    public float criticalChance;
    public float lifesteal;

    public PlayerStatsRuntime(PlayerData playerData)
    {
        health = playerData.health;
        damage = playerData.damage;
        armor = playerData.armor;
        moveSpeed = playerData.moveSpeed;
        attackSpeed = playerData.attackSpeed;
        dodgeChance = playerData.dodgeChance;
        criticalChance = playerData.criticalChance;
        lifesteal = playerData.lifesteal;
    }
}
