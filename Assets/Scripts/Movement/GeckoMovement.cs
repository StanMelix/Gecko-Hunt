using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GeckoMovement : MonoBehaviour
{
    public GameObject Gecko;
    public float Speed;
    private float leftBound = -15;
    public float health;
    private float tempscore = 0;
    public TextMeshProUGUI displayScore;

    void Start()
    {
        SetScoreText();
    }

    public void TakeDamage(float damage)
    {
        health -= damage;

        if (health <= 0)
        {
            tempscore += 1;
            SetScoreText();
            Object.Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerMovement hunter = collision.GetComponent<PlayerMovement>();

        if(hunter != null)
        {
            hunter.TakeDamage(1);
        }
    }

    void SetScoreText()
    {
        displayScore.text = "Score: " + tempscore.ToString();
    }

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
