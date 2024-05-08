using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;
    private Vector2 moveInput;
    public static int health;
    public TextMeshProUGUI displayLives;
    public AudioSource hurt;

    void Start()
    {
        health = 3;
        SetLivesText();
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        SetLivesText();
        hurt.Play();
        if (health <= 0)
        {
            Object.Destroy(this.gameObject);
            SceneManager.LoadScene(2);
        }
    }

    void SetLivesText()
    {
        displayLives.text = "Lives: " + health.ToString();
    }

    void Update()
    {
        moveInput.y = Input.GetAxisRaw("Vertical");
        moveInput.Normalize();
        rb.velocity = moveInput * moveSpeed;
    }

    public void setHealth(int amount)
    {
        health += amount;
    }
}
