using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class YetenekSecimController : MonoBehaviour
{
    private AudioSource audioSource;
    private Button button;
    private MainCharHealth MainCharHealth;
    private LevelBarController LevelBarController;
    private GameObject mainChar;
    private MainCharMovement MainCharMovement;
    // Start is called before the first frame update
    void Start()
    {
        mainChar = GameObject.FindGameObjectWithTag("Player");
        MainCharHealth = mainChar.GetComponent<MainCharHealth>();
        MainCharMovement = mainChar.GetComponent<MainCharMovement>();
        LevelBarController = GameObject.Find("LevelBar").GetComponent<LevelBarController>();

        audioSource = GetComponent<AudioSource>();
        button = GetComponent<Button>();
    }

    public void OnPointerEnter()
    {
        audioSource.Play();
    }

    public void Option1()
    {
        RandomYetenek(LevelBarController.abilityValue1);
        CloseTab();
        StartViewController.IsStart = true;
        ResumeGame();
    }
    public void Option2()
    {
        RandomYetenek(LevelBarController.abilityValue2);
        CloseTab();
        StartViewController.IsStart = true;
        ResumeGame();
    }
    public void Option3()
    {
        RandomYetenek(LevelBarController.abilityValue3);
        CloseTab();
        StartViewController.IsStart = true;
        ResumeGame();
    }



    void ResumeGame()
    {
        Time.timeScale = 1;
    }



    private void CloseTab()
    {
        transform.parent.gameObject.GetComponent<Canvas>().enabled = false;
    }



    public int RandomYetenek(int index)
    {
        Debug.Log(index);
        switch (index)
        {
            case 0:
                {
                    MainCharHealth.currentHealth = MainCharHealth.maxHealth;
                    break;
                }
            case 1:
                {
                    BulletController.damageChar = BulletController.damageChar + (BulletController.damageChar * 20) / 100;
                    break;
                }
            case 2:
                {
                    MainCharMovement.speed = MainCharMovement.speed + MainCharMovement.speed * 20 / 100;
                    break;
                }
            case 3:
                {
                    break;
                }
            case 4:
                {
                    break;
                }
            case 5:
                {
                    break;
                }
            case 6:
                {
                    break;
                }
            default:
                {
                    break;
                }
        }
        
        return 0;
    }
}
