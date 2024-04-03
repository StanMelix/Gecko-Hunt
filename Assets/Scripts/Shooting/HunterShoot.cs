using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HunterShoot : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform shootingPoint;
    public GameObject bullet;
    public float bulletSpeed = 10;
    void Start()
    {
        
    }

    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var bullet1 = Instantiate(bullet, shootingPoint.position, transform.rotation);
            bullet1.GetComponent<Rigidbody2D>().velocity = shootingPoint.right * bulletSpeed;
        }
    }
}
