using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMoving : MonoBehaviour
{
    private float speed = 30;
    private EnemyBehaviour enemyBehaviourScript;

    private void Start()
    {
        enemyBehaviourScript = GameObject.Find("Player").GetComponent<EnemyBehaviour>();
    }

    private void Update()
    {
        if (enemyBehaviourScript.gameOver == false)
        { 
            transform.Translate(Vector3.down*Time.deltaTime * speed);
        }
    }
}
