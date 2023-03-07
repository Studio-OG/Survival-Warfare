using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseTab1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CloseTab()
    {
        transform.parent.gameObject.GetComponent<Canvas>().enabled = false;
    }
}
