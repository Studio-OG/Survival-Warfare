using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    private AudioSource coinAudio;

    private void Start()
    {
        coinAudio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            coinAudio.Play();
            Destroy(collision.gameObject);
            ScoreAndHealth.Score++;

        }
        else if (gameObject.tag == "Coin2")
        {
            coinAudio.Play();
            Destroy(collision.gameObject);
            ScoreAndHealth.Score += 2;
        }


    }
}
