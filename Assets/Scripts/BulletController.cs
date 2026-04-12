using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField]
    public float speed = 10f;
    [SerializeField]
    public float lifetime = 5f;

    private Vector2 direction;

    public void SetDirection(Vector2 dir)
    {
        direction = dir.normalized;
    }

    void Start()
    {
        Destroy(gameObject, lifetime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Monster"))
        {
            IEnemy enemy = collision.GetComponent<IEnemy>();
            if (enemy != null)
            {
                enemy.TakeDamage(50f); 
                Destroy(gameObject);
            }
            
        }
    }


}
