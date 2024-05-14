using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BushSpawner : MonoBehaviour
{
    public GameObject Bush;
    public float minY;
    public float maxY;
    public float minSpawnTime;
    public float maxSpawnTime;
    private float timeBetweenSpawn;
    private float spawnTime = 11;

    private void Update()
    {
        if (Time.timeSinceLevelLoad > spawnTime)
        {
            timeBetweenSpawn = Random.Range(minSpawnTime, maxSpawnTime);
            Spawn();
            spawnTime = Time.timeSinceLevelLoad + timeBetweenSpawn;
        }
    }

    void Spawn()
    {
        float Y = Random.Range(minY, maxY);
        Instantiate(Bush, transform.position + new Vector3(0, Y, 0), transform.rotation);
    }
}
