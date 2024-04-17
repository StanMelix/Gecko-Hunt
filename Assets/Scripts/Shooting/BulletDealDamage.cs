using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDealDamage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GeckoMovement gecko = collision.GetComponent<GeckoMovement>();
        SnakeMovement snake = collision.GetComponent<SnakeMovement>();

        if(gecko != null)
        {
            gecko.TakeDamage(1);
        }
        Object.Destroy(this.gameObject);

        if (snake != null)
        {
            snake.TakeDamage(1);
        }
        Object.Destroy(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x >= 15)
        {
            Object.Destroy(this.gameObject);
        }
    }
}
