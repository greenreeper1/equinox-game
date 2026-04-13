using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public abstract class BaseEnemy : MonoBehaviour, IEnemy
{
    [SerializeField] protected EnemyData data;
    [SerializeField] protected BalanceConfig config;

    protected Transform player;
    protected Rigidbody2D rb;
    protected float attackTimer;
    protected float currentHealth;

    protected virtual void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    protected virtual void Start()
    {
        Initialize(data);
        player = GameObject.FindGameObjectWithTag("Player")?.transform;
    }


    protected virtual void Update()
    {
        if (player == null) return;
        attackTimer -= Time.deltaTime;
        OnUpdate();
    }

    public virtual void Initialize(EnemyData enemyData)
    {
        data = enemyData;
        currentHealth = data.health;
    }

    protected virtual void OnUpdate() { }

    public abstract void Attack();
    public abstract void Move();

    public virtual void TakeDamage(float damage)
    {
        float reduction = GetDamageReduction();
        currentHealth -= damage * (1 - reduction);
        if (currentHealth <= 0) Die();
    }

    public virtual void Die()
    {
        
        Destroy(gameObject);
    }

    protected float GetDamageReduction()
        => data.armor / (data.armor + config.armorK);

    protected float DistanceToPlayer()
        => Vector2.Distance(transform.position, player.position);

    protected Vector2 DirectionToPlayer()
        => ((Vector2)(player.position - transform.position)).normalized;
}
