using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    private float spawnRangeX = 40.0f;
    private float spawnRangeY = 40.0f;
    private float startDelay = 2;
    private float repeatRate = 5;
    private int enemyIndex;
    private int enemyCount;
    public int enemySpawn;
    public int enemyMax=15;
    public int waveNumber;
    public int perWaveEnemyNumber=5;
    

    private MainCharHealth mainCharHealthScript;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomEnemy", startDelay, repeatRate);

        mainCharHealthScript = GameObject.FindGameObjectWithTag("Player").GetComponent<MainCharHealth>();

        enemyCount = enemySpawn;
        enemySpawn = 0;
        waveNumber = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (enemySpawn == enemyMax)
        {
            LevelUp();
   
        }


    }

    void SpawnRandomEnemy()
    {
         

        if (!mainCharHealthScript.gameOver && enemySpawn != enemyMax)
        {
            enemyIndex = Random.Range(0, enemyPrefabs.Length);

            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), spawnRangeY, 0);

            Instantiate(enemyPrefabs[enemyIndex], spawnPos, enemyPrefabs[enemyIndex].transform.rotation);

            enemySpawn++;

        }


    }
    void LevelUp()
    {
        waveNumber++;
        enemyMax = waveNumber * perWaveEnemyNumber;
        enemySpawn = 0;
       
    }

}
