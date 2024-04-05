using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeMovement : MonoBehaviour
{
    public GameObject Snake;
    public float Speed;
    private float leftBound = -16;
    public float health;

    public void TakeDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Object.Destroy(this.gameObject);
        }
    }

    private void Update()
    {

        if (transform.position.x >= leftBound)
        {
            Snake.transform.Translate(((Speed * -1) / 100), 0, 0);
        }
        else
        {
            Object.Destroy(this.gameObject);
        }
    }
}
