using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public GameObject Obstacle;
    public float Speed;
    private float leftBound = -21;

    void Start()
    {

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerMovement hunter = collision.GetComponent<PlayerMovement>();
        BulletDealDamage bullet = collision.GetComponent<BulletDealDamage>();

        if (hunter != null)
        {
            hunter.TakeDamage(1);
        }
    }


    private void Update()
    {

        if (transform.position.x >= leftBound)
        {
            Obstacle.transform.Translate(((Speed * -1) / 100), 0, 0);
        }
        else
        {
            Object.Destroy(this.gameObject);
        }
    }
}
