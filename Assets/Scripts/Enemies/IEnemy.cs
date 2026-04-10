using UnityEngine;

public interface IEnemy
{
    void Attack();
    void Move();
    void Initialize(EnemyData data);
}
