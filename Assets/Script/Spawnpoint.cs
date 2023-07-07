using UnityEngine;

public class Spawnpoint : MonoBehaviour
{
    public GameObject objectToSpawn;  // The object to spawn
    public float spawnInterval = 2f;  // Time between spawns

    private void Start()
    {
        InvokeRepeating("SpawnObject", 0f, spawnInterval);
    }

    private void SpawnObject()
    {
        Instantiate(objectToSpawn, transform.position, transform.rotation);
    }
}
