using UnityEngine;

public class CollectibleCurrency : MonoBehaviour
{
    // variables and constants
    void OnTriggerEnter2D(Collider2D other)
    {
        PlayerController controller = other.GetComponent<PlayerController>();

        if (controller != null)
        {
            Destroy(gameObject);
        }
    }
}
