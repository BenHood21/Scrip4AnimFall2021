using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{
   public GameObject obstacle;
   public GameObject powerUp;
   public float maxX;
   public float minX;
   public float maxY;
   public float minY;

   public float enemyTimeBetweenSpawn;
   private float enemySpawnTime;
   public float powerUpTimeBetweenSpawn;
   private float powerUpSpawnTime;
   void Update()
   {
       if (Time.time > enemySpawnTime)
       {
           Spawn();
           enemySpawnTime = Time.time + enemyTimeBetweenSpawn;
       }

       if (Time.time > powerUpSpawnTime)
       {
           SpawnPowerUp();
           powerUpSpawnTime = Time.time + powerUpTimeBetweenSpawn;
       }
   }

    void Spawn()
    {
        float randomY = UnityEngine.Random.Range(minY, maxY);
        float randomX = UnityEngine.Random.Range(minX, maxX);

        Instantiate(obstacle, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }

    void SpawnPowerUp()
    {
        float randomY = UnityEngine.Random.Range(minY, maxY);
        float randomX = UnityEngine.Random.Range(minX, maxX);
        
        Instantiate(powerUp, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }
}
