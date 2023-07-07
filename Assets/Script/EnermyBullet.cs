using UnityEngine;
using UnityEngine.SceneManagement;

public class EnermyBullet : MonoBehaviour
{

    private float destroyTimer = 1.5f; // Time in seconds before the bullet destroys itself



    private void Start()
    {
        // Start the countdown to destroy the bullet
        Destroy(gameObject, destroyTimer);
    }

}
