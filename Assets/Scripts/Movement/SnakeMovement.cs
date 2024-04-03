using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeMovement : MonoBehaviour
{
    public GameObject Snake;
    public float Speed;
    private float leftBound = -18;

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
