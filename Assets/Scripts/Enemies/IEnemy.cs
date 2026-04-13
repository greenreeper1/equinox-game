using UnityEngine;

public interface IEnemy
{
    void Attack();
    void Move();
    void Initialize(EnemyData data);
    void TakeDamage(float damage);
    void Die();
}
