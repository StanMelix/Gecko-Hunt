using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeMovement : MonoBehaviour
{
    public GameObject Tree;
    public float Speed;
    private float leftBound = -21;

    void Start()
    {

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerMovement hunter = collision.GetComponent<PlayerMovement>();

        if (hunter != null)
        {
            hunter.TakeDamage(1);
        }
    }


    private void Update()
    {

        if (transform.position.x >= leftBound)
        {
            Tree.transform.Translate(((Speed * -1) / 100), 0, 0);
        }
        else
        {
            Object.Destroy(this.gameObject);
        }
    }
}
