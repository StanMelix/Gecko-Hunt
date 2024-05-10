using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDealDamage : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GeckoMovement gecko = collision.GetComponent<GeckoMovement>();
        SnakeMovement snake = collision.GetComponent<SnakeMovement>();
        FireballMovement fireball = collision.GetComponent<FireballMovement>();
        FoodMovement food = collision.GetComponent<FoodMovement>();

        if (gecko != null)
        {
            gecko.TakeDamage(1);
            Object.Destroy(this.gameObject);
        }

        if (snake != null)
        {
            snake.TakeDamage(1);
            Object.Destroy(this.gameObject);
        }

        if(fireball != null)
        {
            Object.Destroy(this.gameObject);
        }

        if (food != null)
        {
            Object.Destroy(this.gameObject);
        }
    }

    void Update()
    {
        if(transform.position.x >= 18.5)
        {
            Object.Destroy(this.gameObject);
        }
    }
}
