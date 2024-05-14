using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeckoSpawner : MonoBehaviour
{
    public GameObject Gecko;
    public float minY;
    public float maxY;
    public float minSpawnTime;
    public float maxSpawnTime;
    private float timeBetweenSpawn;
    private float spawnTime = 2;
    public AudioSource GeckoCry;

    private void Update()
    {
        if(Time.timeSinceLevelLoad > spawnTime)
        {
            timeBetweenSpawn = Random.Range(minSpawnTime, maxSpawnTime);
            Spawn();
            spawnTime = Time.timeSinceLevelLoad + timeBetweenSpawn;
            GeckoCry.Play();
        }
    }

    void Spawn()
    {
        float Y = Random.Range(minY, maxY);
        Instantiate(Gecko, transform.position + new Vector3(0, Y, 0), transform.rotation);
    }
}
