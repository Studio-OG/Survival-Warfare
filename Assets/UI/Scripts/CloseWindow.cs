using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseWindow : MonoBehaviour
{
    public void Deneme()
    {
        Debug.Log("Buton Calisti");
    }
    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Buton Calisti");
    }
}
