using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HamSpawner : MonoBehaviour
{
    public GameObject Ham;
    public GameObject rotHam;
    public float minY;
    public float maxY;
    public float minSpawnTime;
    public float maxSpawnTime;
    private float timeBetweenSpawn;
    private float spawnTime;
    private int objToSpawn;

    private void Update()
    {
        if (Time.time > spawnTime)
        {
            timeBetweenSpawn = Random.Range(minSpawnTime, maxSpawnTime);
            Spawn();
            spawnTime = Time.time + timeBetweenSpawn;
        }
    }

    void Spawn()
    {
        objToSpawn = Random.Range(1, 3);
        float Y = Random.Range(minY, maxY);
        if (objToSpawn == 1)
        {
            Instantiate(Ham, transform.position + new Vector3(0, Y, 0), transform.rotation);
        }
        else
        {
            Instantiate(rotHam, transform.position + new Vector3(0, Y, 0), transform.rotation);
        }
    }
}
