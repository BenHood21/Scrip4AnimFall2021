using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && AmmoTextScript.ammoAmount > 0)
        {
            Shoot();
        }
    }

    void Shoot()
    {
        AmmoTextScript.ammoAmount -= 1;
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
