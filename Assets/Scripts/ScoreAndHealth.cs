using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreAndHealth : MonoBehaviour
{
    public static float Score;
    public TextMeshProUGUI damageText;
    public TextMeshProUGUI speedText;
    public TextMeshProUGUI healthText;

    [SerializeField] private TextMeshProUGUI Scoretext;
    // Start is called before the first frame update
    void Start()
    {

        Score = 0;
    }


    // Update is called once per frame
    void Update()
    {
        speedText.text = "Speed: " + GameObject.FindGameObjectWithTag("Player").GetComponent<MainCharMovement>().speed;
        damageText.text = "Damage: " + BulletController.damageChar.ToString();
        Scoretext.text = "Score: " + Score.ToString();
        healthText.text = "Health: " + GameObject.FindGameObjectWithTag("Player").GetComponent<MainCharHealth>().currentHealth + " / " + GameObject.FindGameObjectWithTag("Player").GetComponent<MainCharHealth>().maxHealth;    
    }
}
