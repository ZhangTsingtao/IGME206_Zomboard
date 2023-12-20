using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    public GameObject zombiePrefab;

    private float timer = 0;
    public float spawnInterval = 1;
    private void Update()
    {
        timer += Time.deltaTime;
        if (timer > spawnInterval)
        {
            SpawnAZombie();
            timer = 0;
        }
    }
    public void SpawnAZombie()
    {
        var zombie = Instantiate(zombiePrefab);
        zombie.transform.position = transform.position;
    }
}
