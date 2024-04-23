using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundSpawner : MonoBehaviour
{
    public GameObject Background;
    public float minSpawnTime;
    public float maxSpawnTime;
    private float timeBetweenSpawn;
    private float spawnTime;

    private void Update()
    {
        if (Time.time > spawnTime)
        {
            timeBetweenSpawn = Random.Range(minSpawnTime, maxSpawnTime);
            print(timeBetweenSpawn);
            Spawn();
            spawnTime = Time.time + timeBetweenSpawn;
        }
    }

    void Spawn()
    {
        Instantiate(Background, transform.position + new Vector3(0, 0, 0), transform.rotation);
    }
}
