using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;

    void Start()
    {
        rb.velocity = transform.up * speed;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
       
        if (other.name == "Astroids")
        {
            Debug.Log("Hit");
            Destroy(gameObject);
        }
        else if (other.name == "Player")
        {
            Debug.Log("Player Shot");
        }

    }
}
