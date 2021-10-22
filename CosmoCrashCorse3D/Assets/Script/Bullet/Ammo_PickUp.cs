using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo_PickUp : MonoBehaviour
{
    public float pickUpSpeed = 15f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            AmmoTextScript.ammoAmount += 2;
            Destroy(gameObject);
        }
        if (other.tag == "Border")
        {
            Destroy(this.gameObject);
        }
    }

    private void Update()
    {
        transform.position += new Vector3( 0 , 0,-pickUpSpeed * Time.deltaTime);

    }
}
