using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBounds : MonoBehaviour
{

    private void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -10.5f, -10.49f), Mathf.Clamp(transform.position.y, -4.8f, 4.8f), transform.position.z);
    }
}
