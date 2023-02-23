using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreAndHealth : MonoBehaviour
{
    public static float Health;
    public static float Score;
    [SerializeField] private TextMeshProUGUI Scoretext;
    // Start is called before the first frame update
    void Start()
    {
        Health = 100;
        Score = 1110;
    }


    // Update is called once per frame
    void Update()
    {
        Scoretext.text = "Score: " + Score.ToString();
    }
}
