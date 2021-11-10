using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FirepointScript : MonoBehaviour
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
