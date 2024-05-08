using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballDealDamage : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerMovement hunter = collision.GetComponent<PlayerMovement>();

        if(hunter != null)
        {
            hunter.TakeDamage(1);
            Object.Destroy(this.gameObject);
        }
        
    }

    void Update()
    {
        
    }
}
