using UnityEngine;

public class headDetect : MonoBehaviour
{
    GameObject Enemy;
    [SerializeField]
    private float bounce = 3f;

    void Start()
    {
        Enemy = gameObject.transform.parent.gameObject;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {   
        PlayerMovement player = collision.gameObject.GetComponent<PlayerMovement>();
        
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * bounce, ForceMode2D.Impulse);
            }

            GetComponent<Collider2D>().enabled = false;
            Enemy.GetComponent<Collider2D>().enabled = false;
    
            Destroy(Enemy.gameObject);
        }
    }
}