using UnityEngine;

public class RangedEnemy : BaseEnemy
{
    [SerializeField] private GameObject projectilePrefab;
    [SerializeField] private float projectileSpeed = 8f;
    [SerializeField] private float preferredDistance = 5f;
    [SerializeField] private float distanceTolerance = 1f;

    protected override void OnUpdate()
    {
        Move();
        if (attackTimer <= 0)
            Attack();
    }

    public override void Move()
    {
        float distance = DistanceToPlayer();

        if (distance < preferredDistance - distanceTolerance)
        {
            // Move away from player
            rb.linearVelocity = -DirectionToPlayer() * data.speed;
        }
        else if (distance > preferredDistance + distanceTolerance)
        {
            // Move towards player
            rb.linearVelocity = DirectionToPlayer() * data.speed;
        }
        else
        {
            // Stay in place
            rb.linearVelocity = Vector2.zero;
        }
    }

    public override void Attack()
    {
        attackTimer = data.attackCooldown;
        GameObject proj = Instantiate(projectilePrefab, transform.position, Quaternion.identity);
        proj.GetComponent<Rigidbody2D>().linearVelocity = DirectionToPlayer() * projectileSpeed;
    }
}
