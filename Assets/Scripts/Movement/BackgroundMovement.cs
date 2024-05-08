using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovement : MonoBehaviour
{
    public GameObject Background;
    public float Speed;
    private float leftBound = -36;

    void Update()
    {
        if (transform.position.x >= leftBound)
        {
            Background.transform.Translate(((Speed * -1) / 100), 0, 0);
        }
        else
        {
            Object.Destroy(this.gameObject);
        }
    }
}
