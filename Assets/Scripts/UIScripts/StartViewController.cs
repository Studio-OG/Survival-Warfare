using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartViewController : MonoBehaviour
{
    public static bool IsStart = false;
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
}
