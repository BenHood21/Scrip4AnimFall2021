﻿using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{
   public GameObject obstacle;
   public float maxX;
   public float minX;
   public float maxY;
   public float minY;
   public float timeBetweenSpawn;
   private float spawnTime;

    void Update()
   {
       if (Time.time > spawnTime)
       {
           Spawn();
           spawnTime = Time.time + timeBetweenSpawn;
       }
   }

    void Spawn()
    {
        float randomY = UnityEngine.Random.Range(minY, maxY);
        float randomX = UnityEngine.Random.Range(minX, maxX);

        Instantiate(obstacle, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);

    }
}
