using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    private float spawnRangeX = 40.0f;
    private float spawnRangeY = 40.0f;
    private float startDelay = 2;
    private float repeatRate = 2;
    private int enemyIndex;
   
    private int Enemy;
    
    private int maxEnemy = 50;
    

    // Start is called before the first frame update
    void Start()
    {
        Enemy = 0;
       
        InvokeRepeating("SpawnRandomEnemy", startDelay, repeatRate);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomEnemy()
    {
        if (Enemy <= maxEnemy)
        {
            enemyIndex = Random.Range(0, enemyPrefabs.Length);
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), spawnRangeY, 0);

            Instantiate(enemyPrefabs[enemyIndex], spawnPos, enemyPrefabs[enemyIndex].transform.rotation);
        }

        
    }


}
