using UnityEngine;

public class wallsuicide : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Check if the object collides with a bullet
        if (other.CompareTag("Bullet") || other.CompareTag("enermyBullet"))
        {
            // Destroy the object itself
            Destroy(gameObject);

            Destroy(other.gameObject);
        }
    }
}
