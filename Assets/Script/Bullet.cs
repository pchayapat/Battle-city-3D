using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bullet : MonoBehaviour
{
    public string targetTag; // The tag of the objects to destroy
    private float destroyTimer = 1.5f; // Time in seconds before the bullet destroys itself



    private void Start()
    {
        // Start the countdown to destroy the bullet
        Destroy(gameObject, destroyTimer);



    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the collided object has the specified tag
        if (other.CompareTag(targetTag))
        {
            // Destroy the collided object
            Destroy(other.gameObject);
            Score.Instance.IncreaseScore();
        }
    }
}
