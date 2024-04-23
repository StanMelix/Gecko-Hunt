using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeSpawner : MonoBehaviour
{
    public GameObject Snake;
    public float minY;
    public float maxY;
    public float minSpawnTime;
    public float maxSpawnTime;
    private float timeBetweenSpawn;
    private float spawnTime = 10;

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
        float Y = Random.Range(minY, maxY);
        Instantiate(Snake, transform.position + new Vector3(0, Y, 0), transform.rotation);
    }
}
