
using System;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public float enemySpeed = 15f;
    private GameObject player;
    private GameObject enemy;

    public bool gameOver = false;
    void Start()
    {
        enemy = GameObject.FindGameObjectWithTag("Enemy");
        player = GameObject.FindGameObjectWithTag("Player");
        Rigidbody2D rb = GetComponent<Rigidbody2D>();

    }


    private void Update()
    {
        transform.position += new Vector3( 0 ,-enemySpeed * Time.deltaTime, 0);

    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Border")
        {
            Destroy(this.gameObject);
        }

        else if (other.tag == "Player")
        {
            gameOver = true;
            Debug.Log("Game Over!");
            Destroy(player.gameObject);
        }

        else if (other.tag == "Bullet")
        {
            Destroy(this.gameObject);
        }
    }
}
