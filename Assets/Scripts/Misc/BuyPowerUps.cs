using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BuyPowerUps : MonoBehaviour
{
    public TextMeshProUGUI displayAmmo;
    public TextMeshProUGUI displayLives;
    public AudioSource loadAmmo;
    public AudioSource drinkPotion;

    public void BuyAmmo()
    {
        if (ScoreManager.getScore() >= 20)
        {
            HunterShoot.increaseAmmo(20);
            ScoreManager.scoreCount -= 20;
            displayAmmo.text = "Ammo: " + HunterShoot.ammo.ToString();
            loadAmmo.Play();
        }
    }

    public void BuyHealth()
    {
        if (ScoreManager.getScore() >= 20)
        {
            if (PlayerMovement.health < 3) {
                PlayerMovement.health += 1;
                ScoreManager.scoreCount -= 20;
                displayLives.text = "Lives: " + PlayerMovement.health.ToString();
                drinkPotion.Play();
            }
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            BuyAmmo();
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            BuyHealth();
        }
    }
}
