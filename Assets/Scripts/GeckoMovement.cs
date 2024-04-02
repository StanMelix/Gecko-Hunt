using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeckoMovement : MonoBehaviour
{
    public GameObject Gecko;
    public float Speed;
    private float leftBound = -11;

    private void Update()
    {
        
        if(transform.position.x >= leftBound)
        {
            Gecko.transform.Translate(((Speed * -1)/100), 0, 0);
        }
        else
        {
            Object.Destroy(this.gameObject);
        }
    }
}
