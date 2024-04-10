using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;
    private Vector2 moveInput;
    public float health;
    public TextMeshProUGUI displayLives;

    // Start is called before the first frame update
    void Start()
    {
        SetLivesText();
    }

    public void TakeDamage(float damage)
    {
        health -= damage;
        SetLivesText();
        if (health <= 0)
        {
            Object.Destroy(this.gameObject);
        }
    }

    void SetLivesText()
    {
        displayLives.text = "Lives: " + health.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        moveInput.y = Input.GetAxisRaw("Vertical");
        moveInput.Normalize();
        rb.velocity = moveInput * moveSpeed;
    }
}
