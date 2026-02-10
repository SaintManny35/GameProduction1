using UnityEngine;

public class CollectibleCurrency : MonoBehaviour
{
    // variables and constants
    void OnTriggerEnter2D(Collider2D other)
    {
        PlayerMovement controller = other.GetComponent<PlayerMovement>();

        if (controller != null)
        {
            Destroy(gameObject);
        }
    }
}
