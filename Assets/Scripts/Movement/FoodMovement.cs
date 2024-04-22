using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodMovement : MonoBehaviour
{
    public GameObject Fruit;
    public float Speed;
    private float leftBound = -18;
    public int score;

    void Start()
    {

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerMovement hunter = collision.GetComponent<PlayerMovement>();

        if (hunter != null)
        {
            Object.Destroy(this.gameObject);
            ScoreManager.scoreCount += score;
        }
    }


    private void Update()
    {

        if (transform.position.x >= leftBound)
        {
            Fruit.transform.Translate(((Speed * -1) / 100), 0, 0);
        }
        else
        {
            Object.Destroy(this.gameObject);
        }
    }
}
