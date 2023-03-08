using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGunHealth : MonoBehaviour
{
    
    public int health;
    void Start()
    {
        
    }


    void Update()
    {
        

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Bullet")
        {
            health--;
        }
    }
}
