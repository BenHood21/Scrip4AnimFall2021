using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleBehaviour : MonoBehaviour
{
    private GameObject player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Border")
        {
            Destroy(this.gameObject);
        }

        else if (other.tag == "Player")
        {
            Destroy(player.gameObject);
        }
      
    }
}
