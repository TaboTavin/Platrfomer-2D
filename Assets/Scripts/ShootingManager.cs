using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingManager : MonoBehaviour
{
    public ObjectPool bulletPool;

    private void Start()
    {
        bulletPool = GameObject.Find("BulletPool").GetComponent<ObjectPool>();
    }

    public Transform bulletSpawnPoint;
    public float bulletSpeed = 5f;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        GameObject bullet = bulletPool.GetBulletFromPool();
        Rigidbody2D bulletRigidbody = bullet.GetComponent<Rigidbody2D>();
        bulletRigidbody.velocity = bulletSpawnPoint.forward * bulletSpeed;
        bulletRigidbody.AddForce(Vector2.right * bulletSpeed, ForceMode2D.Impulse);
        bullet.SetActive(true);
    }
}
