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

    public Animator animator;


    [SerializeField] private ShootCooldown cooldown;

    void Start()
    {
        animator.SetBool("IsShooting", false);
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
        if (!(cooldown.IsCoolingDown)) {
            animator.SetBool("IsShooting", false);
        }
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (cooldown.IsCoolingDown) return;
            if (ammo <= 0) return;

            rifleFire.Play();
            animator.SetBool("IsShooting", true);
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
