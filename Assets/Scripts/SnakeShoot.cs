using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeShoot : MonoBehaviour
{
    public Transform Mouth;
    public GameObject Fireball;
    public float minShootTime;
    public float maxShootTime;
    private float timeBetweenSpawn;
    private float spawnTime;
    void Start()
    {
        
    }

    void Update()
    {
        if (Time.time > spawnTime)
        {
            timeBetweenSpawn = Random.Range(minShootTime, maxShootTime);
            Spawn();
            spawnTime = Time.time + timeBetweenSpawn;
        }
    }

    void Spawn()
    {
        Instantiate(Fireball, Mouth.position, transform.rotation);
    }
}
