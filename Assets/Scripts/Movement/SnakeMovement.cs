using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SnakeMovement : MonoBehaviour
{
    public GameObject Snake;
    public float Speed;
    private float leftBound = -20;
    public float health;
    public TextMeshProUGUI displayScore;
    public int score;

    public void TakeDamage(float damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Object.Destroy(this.gameObject);
            ScoreManager.scoreCount += score;
            ScoreManager.totalScore += score;
        }
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
            Snake.transform.Translate(((Speed * -1) / 100), 0, 0);
        }
        else
        {
            Object.Destroy(this.gameObject);
        }
    }
}
