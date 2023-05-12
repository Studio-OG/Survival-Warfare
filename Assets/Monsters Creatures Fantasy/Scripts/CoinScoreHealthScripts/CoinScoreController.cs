using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEditor;
using UnityEngine;

public class CoinScoreController : MonoBehaviour
{
    public static int coin2Value = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (gameObject.tag == "Coin")
            {
                GetComponent<AudioSource>().Play();
                ScoreAndHealth.Score++;
            }
            else if(gameObject.tag == "Coin2")
            {
                GetComponent<AudioSource>().Play();
                ScoreAndHealth.Score+= coin2Value;
            }
            Object.Destroy(gameObject);
        }
    }
}
