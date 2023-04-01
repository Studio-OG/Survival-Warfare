using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuViewController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCredits()
    {
        CreditsController.CreditsOn();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
        StartViewController.IsStart = false;
    }
}
