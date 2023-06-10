using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public GameObject bulletPreFab; // Prefab de Bullet
    public int poolSize = 10; // Size pool

    private List<GameObject> bulletPool;

    private void Start()
    {
        // Inicializar Pool de objetos
        bulletPool = new List<GameObject>();

        for (int i = 0; i < poolSize; i++)
        {
            GameObject bullet = Instantiate(bulletPreFab);
            bullet.SetActive(false);
            bulletPool.Add(bullet);
        }

        return;
    }

    public GameObject GetBulletFromPool()
    {
        for (int i = 0; i < bulletPool.Count; i++)
        {
            if (!bulletPool[i].activeInHierarchy)
            {
                return bulletPool[i];
            }
        }

        GameObject newBullet = Instantiate(bulletPreFab);
        bulletPool.Add(newBullet);
        return newBullet;
    }
}
