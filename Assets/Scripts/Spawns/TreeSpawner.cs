using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeSpawner : MonoBehaviour
{
    public GameObject Tree;
    public float minY;
    public float maxY;
    public float minSpawnTime;
    public float maxSpawnTime;
    private float timeBetweenSpawn;
    private float spawnTime = 16;

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
        Instantiate(Tree, transform.position + new Vector3(0, Y, 0), transform.rotation);
    }
}
