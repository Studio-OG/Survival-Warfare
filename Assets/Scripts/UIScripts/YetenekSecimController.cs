using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YetenekSecimController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Option1()
    {
        Debug.Log("1. secenek secildi");
        CloseTab();
        StartViewController.IsStart = true;
        ResumeGame();
    }
    public void Option2()
    {
        Debug.Log("2. secenek secildi");
        CloseTab();
        StartViewController.IsStart = true;
        ResumeGame();
    }
    public void Option3()
    {
        Debug.Log("3. secenek secildi");
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
}
