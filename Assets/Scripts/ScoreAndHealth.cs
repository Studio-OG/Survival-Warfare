using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreAndHealth : MonoBehaviour
{
    public static int totalScore;
    public static float Score;
    public TextMeshProUGUI damageText;
    public TextMeshProUGUI speedText;
    public TextMeshProUGUI healthText;
    public TextMeshProUGUI totalScoreText;

    [SerializeField] private TextMeshProUGUI Scoretext;
    // Start is called before the first frame update
    void Start()
    {
        totalScore = 0;
        Score = 0;
    }


    // Update is called once per frame
    void Update()
    {
        totalScoreText.text = totalScore.ToString();
        speedText.text = "Speed: " + GameObject.FindGameObjectWithTag("Player").GetComponent<MainCharMovement>().speed;
        damageText.text = "Damage: " + BulletController.damageChar.ToString();
        Scoretext.text = Score.ToString() + " / " + GameObject.Find("LevelBar").GetComponent<Slider>().maxValue; ;
        healthText.text = "Health: " + GameObject.FindGameObjectWithTag("Player").GetComponent<MainCharHealth>().currentHealth + " / " + GameObject.FindGameObjectWithTag("Player").GetComponent<MainCharHealth>().maxHealth;    
    }
}
