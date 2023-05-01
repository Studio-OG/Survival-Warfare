using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class CoinController : MonoBehaviour
{
    public void InstantiateCoin(GameObject coin,Vector3 position)
    {
        Instantiate(coin, position, Quaternion.identity);
    }
}
