using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelBarController : MonoBehaviour
{
    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        slider.value = slider.minValue;
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = ScoreAndHealth.Score;
        if (slider.value == slider.maxValue)
        {
            ScoreAndHealth.Score = 0;
            slider.maxValue+=5;
            slider.value = slider.minValue;
        }
    }


}