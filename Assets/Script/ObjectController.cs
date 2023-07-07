// using UnityEngine;
// using UnityEngine.SceneManagement;
// public class ObjectController : MonoBehaviour
// {

//     public float speed = 10.0f;
//     public float rotationSpeed = 100.0f;

//     public string targetTag; // The tag of the objects to destroy

//     private int triggerCount = 0; // The number of times the object has triggered with the target object
//     public string sceneToChange;
//     public int health = 3;
//     void Update()
//     {
//         float translation = Input.GetAxis("Vertical") * speed;
//         float rotation = Input.GetAxis("Horizontal") * rotationSpeed;

//         // Make it move 10 meters per second instead of 10 meters per frame...
//         translation *= Time.deltaTime;
//         rotation *= Time.deltaTime;

//         // Move translation along the object's z-axis
//         transform.Translate(0, 0, translation);

//         // Rotate around our y-axis
//         transform.Rotate(0, rotation, 0);
//     }
//     private void OnTriggerEnter(Collider other)
//     {
//         // Check if the collided object has the specified tag
//         if (other.CompareTag(targetTag))
//         {
//             triggerCount++; // Increment the trigger count

//             if (triggerCount >= health)
//             {
//                 SceneManager.LoadScene(sceneToChange);
//             }
//         }
//     }
// }

//Control //Take Damage //Health Systems

using UnityEngine;
using UnityEngine.SceneManagement;
public class ObjectController : MonoBehaviour
{

    public float speed = 10.0f;
    public float rotationSpeed = 100.0f;

    public string targetTag; // The tag of the objects to destroy

    //private int triggerCount = 0; // The number of times the object has triggered with the target object
    public string sceneToChange;
    public int health = 3;

    public GameObject[] hearts;
    private int life;
    private bool dead;

    private void Start()
    {
        life = hearts.Length;
    }

    void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;

        // Make it move 10 meters per second instead of 10 meters per frame...
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;

        // Move translation along the object's z-axis
        transform.Translate(0, 0, translation);

        // Rotate around our y-axis
        transform.Rotate(0, rotation, 0);

        if (dead == true)
        {
            SceneManager.LoadScene(sceneToChange);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the collided object has the specified tag
        if (other.CompareTag(targetTag))
        {
            if(life >= 1)
            {
                life -= 1;
                Destroy(hearts[life].gameObject);
                if(life<1)
                {
                    dead = true;
                }
            }
        }
    }
}