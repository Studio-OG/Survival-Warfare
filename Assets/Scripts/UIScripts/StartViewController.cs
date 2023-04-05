using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class StartViewController : MonoBehaviour
{
    public static bool IsStart = false;
    private bool musicStatus = true;
    public AudioSource mainMusic;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }



    public void StartGame()
    {
        ResumeGame();
        transform.parent.gameObject.transform.parent.gameObject.GetComponent<Canvas>().enabled = false;
        IsStart = true;
    }

    public void ExitGame()
    {
        Debug.Log("Exit Çalýþtý");
        Application.Quit();
    }

    public void Credits()
    {
        CreditsController.CreditsOn();
    }

    public static bool IsStarted()
    {
        return IsStart;
    }


    void PauseGame()
    {
        Time.timeScale = 0;
    }
    void ResumeGame()
    {
        Time.timeScale = 1;
    }

    public void MusicStatus()
    {
        if (musicStatus)
        {
            musicStatus = false;
            mainMusic.Stop();
            transform.GetChild(0).gameObject.SetActive(false);
            transform.GetChild(1).gameObject.SetActive(true);

        }
        else
        {
            musicStatus = true;
            mainMusic.Play();
            transform.GetChild(0).gameObject.SetActive(true);
            transform.GetChild(1).gameObject.SetActive(false);
        }

    }
}
