using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsController : MonoBehaviour
{
    private static Canvas canvas;
    // Start is called before the first frame update
    void Start()
    {
        canvas = GetComponent<Canvas>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void CreditsOn()
    {
       canvas.enabled = true;
    }


    public static void CreditsOff()
    {
        canvas.enabled = false;

    }
}
