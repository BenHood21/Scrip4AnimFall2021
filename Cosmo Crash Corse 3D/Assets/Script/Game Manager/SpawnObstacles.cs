using System.Collections;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class SpawnObstacles : ScriptableObject
{
   public GameObject enemy;
   public GameObject powerUp;
   public float maxX;
   public float minX;
   public float maxY;
   public float minY;
   public bool canRun = true;
   public float holdTime = 2f;

   public UnityEvent startEvent;
   public float enemyTimeBetweenSpawn;
   private float enemySpawnTime;
   public float powerUpTimeBetweenSpawn;
   private float powerUpSpawnTime;
   private WaitForSeconds wfs;

   private IEnumerator Start()
   {
       wfs = new WaitForSeconds(holdTime);

       while (canRun)
       {
           yield return wfs;
           startEvent.Invoke();
       }
   }
   
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

     //   Instantiate(enemy, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }

    void SpawnPowerUp()
    {
        float randomY = UnityEngine.Random.Range(minY, maxY);
        float randomX = UnityEngine.Random.Range(minX, maxX);
        
       // Instantiate(powerUp, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }
}
