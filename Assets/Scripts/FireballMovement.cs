using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballMovement : MonoBehaviour
{
    public GameObject Fireball;
    public float Speed;
    private float leftBound = -16;

    private void Update()
    {

        if (transform.position.x >= leftBound)
        {
            Fireball.transform.Translate(((Speed * -1) / 100), 0, 0);
        }
        else
        {
            Object.Destroy(this.gameObject);
        }
    }
}
