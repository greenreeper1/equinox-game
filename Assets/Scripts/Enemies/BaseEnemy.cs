using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public abstract class BaseEnemy : MonoBehaviour, IEnemy
{
    [SerializeField] protected EnemyData data;

    protected Transform player;
    protected Rigidbody2D rb;
    protected float attackTimer;

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
    }

    protected virtual void OnUpdate() { }

    public abstract void Attack();
    public abstract void Move();

    protected float DistanceToPlayer()
        => Vector2.Distance(transform.position, player.position);

    protected Vector2 DirectionToPlayer()
        => ((Vector2)(player.position - transform.position)).normalized;
}
