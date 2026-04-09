using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField]
    public float speed = 10f;

    private Vector2 direction;

    public void SetDirection(Vector2 dir)
    {
        direction = dir.normalized;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }

    void Destroy()
    {
        Destroy(gameObject, 5f);
    }
}
