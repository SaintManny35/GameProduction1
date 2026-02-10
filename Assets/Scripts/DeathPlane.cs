using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DeathPlane : MonoBehaviour {
    
    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.GetComponent<PlayerMovement>())
        SceneManager.LoadScene(0);
    }
}