using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;

public class HunterShoot : MonoBehaviour
{
    public Transform shootingPoint;
    public GameObject bullet;
    public float bulletSpeed = 50;
    public AudioSource rifleFire;
    public static int ammo;
    public TextMeshProUGUI displayAmmo;

    [SerializeField] private ShootCooldown cooldown;

    void Start()
    {
        ammo = 20;
        rifleFire = GetComponent<AudioSource>();
        SetAmmoText();
    }

    void SetAmmoText()
    {
        displayAmmo.text = "Ammo: " + ammo.ToString();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (cooldown.IsCoolingDown) return;
            if (ammo <= 0) return;

            rifleFire.Play();
            var bullet1 = Instantiate(bullet, shootingPoint.position, transform.rotation);
            bullet1.GetComponent<Rigidbody2D>().velocity = shootingPoint.right * bulletSpeed;
            ammo -= 1;
            SetAmmoText();

            cooldown.StartCooldown();
        }
    }
    public static void increaseAmmo(int amount)
    {
        ammo += amount;
    }
}
