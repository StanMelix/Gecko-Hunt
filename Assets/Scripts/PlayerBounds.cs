using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBounds : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -15f, -11f), Mathf.Clamp(transform.position.y, -4f, 4f), transform.position.z);
    }
}
