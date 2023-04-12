using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSFX : MonoBehaviour
{
    private AudioSource source;
    public AudioClip[] menuSFX;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerEnter()
    {
        int index = Random.Range(0, menuSFX.Length);
        source.PlayOneShot(menuSFX[index]);
    }
}
