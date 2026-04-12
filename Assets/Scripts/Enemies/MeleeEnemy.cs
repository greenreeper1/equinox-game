using UnityEngine;

public class MeleeEnemy : BaseEnemy
{
    protected override void OnUpdate()
    {
        Move();
        if(DistanceToPlayer() < 0.5f)
        {
            Attack();
        }
    }

    public override void Move()
    {
        rb.linearVelocity = DirectionToPlayer() * data.speed;
    }

    public override void Attack()
    {
        if (attackTimer > 0) return;
        attackTimer = data.attackCooldown;
        Debug.Log($"MeleeEnemy attacks for {data.attackDamage} damage!");
    }
}
