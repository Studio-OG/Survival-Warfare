using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LevelBarController : MonoBehaviour
{
    public Slider slider;
    public Canvas levelUpCanvas;
    public string[] yetenekAciklamalar;
    public TextMeshProUGUI yetenek1Text;
    public TextMeshProUGUI yetenek2Text;
    public TextMeshProUGUI yetenek3Text;
    public  int abilityValue1;
    public  int abilityValue2;
    public  int abilityValue3;


    // Start is called before the first frame update
    void Start()
    {
        slider.value = slider.minValue;
        yetenekAciklamalar = new string[7];
        yetenekAciklamalar[0] = "Bu g��lendirme can�n� fuller";
        yetenekAciklamalar[1] = "Bu g��lendirme hasar�n�z %20 oran�nda artt�r�r";
        yetenekAciklamalar[2] = "Bu g��lendirme hareket h�z�n� %20 oran�nda artt�r�r";
        yetenekAciklamalar[3] = "Bu g��lendirme can�n� yar� yar�ya azaltabilir(%50) yada can�n� fuller ve hasar�n� %50 artt�r�r(%50)";
        yetenekAciklamalar[4] = "Bu g��lendirme seni �ld�rebilir(%50) yada hasar�n� 2 ye katlar(%50)";
        yetenekAciklamalar[5] = "?";
        yetenekAciklamalar[6] = "Bu g��lendirme Sar� coinlerden fazla puan alman� sa�lar";
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = ScoreAndHealth.Score;
        if (slider.value == slider.maxValue)
        {
            levelUpCanvas.enabled = true;
            RandomAbility();
            StartViewController.IsStart = false;
            PauseGame();

            ScoreAndHealth.Score = 0;
            slider.maxValue += 5;
            //slider.value = slider.minValue;

            GameObject spawnManagerObject = GameObject.Find("SpawnManager");
            SpawnManager spawnManagerScript = spawnManagerObject.GetComponent<SpawnManager>();
            spawnManagerScript.spawnInterval -= 2f;
        }
    }

    private void RandomAbility()
    {
        while (true)
        {
            abilityValue1 = Random.Range(0, 7);
            abilityValue2 = Random.Range(0, 7);
            abilityValue3 = Random.Range(0, 7);
            if (abilityValue1 != abilityValue2 && abilityValue2 != abilityValue3 && abilityValue1 != abilityValue3)
            {
                break;
            }
        }
        yetenek1Text.text = yetenekAciklamalar[abilityValue1];
        yetenek2Text.text = yetenekAciklamalar[abilityValue2];
        yetenek3Text.text = yetenekAciklamalar[abilityValue3];


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
