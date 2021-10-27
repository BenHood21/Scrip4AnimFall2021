using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirepointScript : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    void Update()
    {
        if (Input.touchCount >0 && AmmoTextScript.ammoAmount > 0)
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
