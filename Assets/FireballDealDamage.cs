using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballDealDamage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerMovement hunter = collision.GetComponent<PlayerMovement>();

        if(hunter != null)
        {
            hunter.TakeDamage(1);
            Object.Destroy(this.gameObject);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
