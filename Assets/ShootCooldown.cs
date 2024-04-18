using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ShootCooldown
{
    [SerializeField] private float cooldownTime;
    private float nextFireTime;

    public bool IsCoolingDown => Time.time < nextFireTime;
    public void StartCooldown() => nextFireTime = Time.time + cooldownTime;
}
