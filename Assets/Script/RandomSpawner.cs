using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject SpawnPrefab;

    public float interval = 1f;

    void Start()
    {
        StartCoroutine(SpawnPrefabs());
    }

    IEnumerator SpawnPrefabs()
    {
        while (true)
        {
            yield return new WaitForSeconds(interval);

            Vector3 randomSpawnPosition = new Vector3(Random.Range(-130, 130), 5, Random.Range(-130, 130));
            Instantiate(SpawnPrefab, randomSpawnPosition, Quaternion.identity);
        }
    }
}
