using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;

public class HunterShoot : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform shootingPoint;
    public GameObject bullet;
    public float bulletSpeed = 50;
    public AudioSource rifleFire;
    public float ammo;
    public TextMeshProUGUI displayAmmo;

    [SerializeField] private ShootCooldown cooldown;

    void Start()
    {
        rifleFire = GetComponent<AudioSource>();
        SetAmmoText();
    }

    void SetAmmoText()
    {
        displayAmmo.text = "Ammo: " + ammo.ToString();
    }

    // Update is called once per frame
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
}
