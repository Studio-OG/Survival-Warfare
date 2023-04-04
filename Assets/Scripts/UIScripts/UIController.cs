using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public Canvas CanvasCredits;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        EscMenu();
    }


    public void EscMenu()
    {
        
        if (Input.GetKeyDown(KeyCode.Escape) && StartViewController.IsStarted() && !CanvasCredits.enabled)
        {
            if (Time.timeScale != 0)
            {
                gameObject.GetComponent<Canvas>().enabled = true;
                PauseGame();

            }
            else if (Time.timeScale == 0)
            {
                gameObject.GetComponent<Canvas>().enabled = false;
                ResumeGame();
            }
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
