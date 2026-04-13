using UnityEngine;

[CreateAssetMenu(fileName = "EnemyData", menuName = "Roguelike/Enemy Data")]
public class EnemyData : ScriptableObject
{
    public float speed = 3f;
    public float health = 100f;
    public float armor = 0f;
    public float attackRange = 1.5f;
    public float attackDamage = 10f;
    public float attackCooldown = 1f;
}
