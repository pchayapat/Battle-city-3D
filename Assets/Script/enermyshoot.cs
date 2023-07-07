using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class enermyshoot : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10;
    public float shootInterval = 2f; // Time between shots
 
    private bool canShoot = true; // Flag to control shooting
 
    void Start()
    {
        StartCoroutine(ShootRoutine());
    }
 
    IEnumerator ShootRoutine()
    {
        while (true)
        {
            if (canShoot)
            {
                var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
                bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
            }
 
            yield return new WaitForSeconds(shootInterval); // Wait for the specified interval
        }
    }
}
