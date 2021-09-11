using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo_PickUp : MonoBehaviour
{
    public float pickUpSpeed = 15f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            AmmoTextScript.ammoAmount += 6;
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        transform.position += new Vector3( 0 ,-pickUpSpeed * Time.deltaTime, 0);

    }
}
