using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundSpawner : MonoBehaviour
{
    public GameObject Background;
    public float spawnIncrement;
    private float spawnTime;

    private void Update()
    {
        if (Time.time > spawnTime)
        {
            Spawn();
            spawnTime = Time.time + spawnInc;
        }
    }

    void Spawn()
    {
        Instantiate(Background, transform.position + new Vector3(0, 0, 0), transform.rotation);
    }
}
