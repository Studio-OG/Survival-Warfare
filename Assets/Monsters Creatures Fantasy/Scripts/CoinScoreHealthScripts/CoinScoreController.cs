using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScoreController : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (gameObject.tag == "Coin")
            {
                ScoreAndHealth.Score++;
            }
            else if(gameObject.tag == "Coin2")
            {
                ScoreAndHealth.Score+=2;
            }
            Object.Destroy(gameObject);
        }
    }
}
