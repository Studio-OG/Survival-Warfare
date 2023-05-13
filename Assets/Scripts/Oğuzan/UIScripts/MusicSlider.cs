using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicSlider : MonoBehaviour
{
    [SerializeField] private GameObject mainCamera;
    private AudioSource mainSource;
    private Slider musicSlider;
    // Start is called before the first frame update
    void Start()
    {
        mainSource = mainCamera.GetComponent<AudioSource>();
        musicSlider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        mainSource.volume = musicSlider.value;
    }
}
