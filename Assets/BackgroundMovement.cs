using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovement : MonoBehaviour
{
    public GameObject Background;
    public float Speed;
    private float leftBound = -36;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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
