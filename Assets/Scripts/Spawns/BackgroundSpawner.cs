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
        if (Time.timeSinceLevelLoad > spawnTime)
        {
            Spawn();
            spawnTime = Time.timeSinceLevelLoad + spawnIncrement;
        }
    }

    void Spawn()
    {
        Instantiate(Background, transform.position + new Vector3(0, 0, 0), transform.rotation);
    }
}
