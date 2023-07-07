using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public string targetTag; // The tag of the objects to destroy

    private int triggerCount = 0; // The number of times the object has triggered with the target object
    public string sceneToChange;
    private void OnTriggerEnter(Collider other)
    {
        // Check if the collided object has the specified tag
        if (other.CompareTag(targetTag))
        {
            triggerCount++; // Increment the trigger count

            if (triggerCount >= 3)
            {
                SceneManager.LoadScene(sceneToChange);
            }
        }
    }
}
