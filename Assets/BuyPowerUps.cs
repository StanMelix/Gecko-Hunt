using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BuyPowerUps : MonoBehaviour
{
    public TextMeshProUGUI displayAmmo;
    public void BuyAmmo()
    {
        if (ScoreManager.getScore() >= 20)
        {
            HunterShoot.increaseAmmo(20);
            ScoreManager.scoreCount -= 20;
            displayAmmo.text = "Ammo: " + HunterShoot.ammo.ToString();
        }
    }

    public void BuyHealth()
    {
        Debug.Log("*buys pretend health*");
        //PlayerMovement.health += 1;
    }
}
