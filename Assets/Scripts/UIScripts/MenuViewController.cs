using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuViewController : MonoBehaviour
{
    public Scene scene2;
    // Start is called before the first frame update
    void Start()
    {
        scene2 = SceneManager.GetActiveScene();
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
        SceneManager.LoadScene(scene2.name);
        StartViewController.IsStart = false;
    }
}
