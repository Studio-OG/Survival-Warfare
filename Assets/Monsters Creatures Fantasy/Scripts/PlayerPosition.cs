using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPosition : MonoBehaviour
{
    public static Transform Playerposition;

    private void Start()
    {
        Playerposition = GetComponent<Transform>();
    }
    // Update is called once per frame
    void Update()
    {
       

    }
}
