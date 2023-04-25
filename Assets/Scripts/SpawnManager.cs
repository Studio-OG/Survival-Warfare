using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public int perWaveEnemyNumber = 5;
    public float spawnDelay = 4.0f;
    public float spawnInterval = 10.0f;
    public int enemySpawn;
    public int enemyMax = 15;
   
    private MainCharHealth mainCharHealthScript;

    void Start()
    {
        
        InvokeRepeating("SpawnWave", spawnDelay, spawnInterval);
        mainCharHealthScript = GameObject.FindGameObjectWithTag("Player").GetComponent<MainCharHealth>();
        enemySpawn = 0;
        
    }

    void Update()
    {
        

    }


    void SpawnWave()
    {

        if (!mainCharHealthScript.gameOver && enemySpawn != enemyMax)
        {
            for (int i = 0; i < perWaveEnemyNumber; i++)
            {
                float randX = Random.Range(-40.0f, 40.0f);
                float randY = Random.Range(-40.0f, 40.0f);
                Vector3 randPos = new Vector3(randX, randY, 0.0f);
                GameObject randEnemyPrefab = enemyPrefabs[Random.Range(0, enemyPrefabs.Length)];
                Instantiate(randEnemyPrefab, randPos, randEnemyPrefab.transform.rotation);
                enemySpawn++;
            }
        }

          
           
    }



    
}
