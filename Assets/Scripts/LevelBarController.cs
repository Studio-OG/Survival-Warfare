using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelBarController : MonoBehaviour
{
    public Slider slider;
    public Canvas levelUpCanvas;
    private SpawnManager spawnManagerScript;

    // Start is called before the first frame update
    void Start()
    {
        slider.value = slider.minValue;
        spawnManagerScript = GameObject.Find("SpawnManager").GetComponent<SpawnManager>();
    }
    // Update is called once per frame
    void Update()
    {
        slider.value = ScoreAndHealth.Score;
        if (slider.value == slider.maxValue)
        {
            levelUpCanvas.enabled = true;
            StartViewController.IsStart = false;
            PauseGame();

            ScoreAndHealth.Score = 0;
            slider.maxValue += 5;
            //slider.value = slider.minValue;

            spawnManagerScript.StopCoroutine("SpawnWave"); //SpawnManagerın çalışmasını durdur

           
            spawnManagerScript.spawnInterval -= 2f;


            spawnManagerScript.StartCoroutine("SpawnWave"); //SpawnManagerın tekrar çalışmasını sağla

        }
    }



    void PauseGame()
    {
        Time.timeScale = 0;
    }
    void ResumeGame()
    {
        Time.timeScale = 1;
    }
}
