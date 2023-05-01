using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    private Vector2 target;
    public float speed;
   

    void Start()
    {

        target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);

        Destroy(gameObject, 2f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            collision.GetComponent<EnemyHealth>().TakeDamage(50);
            Destroy(gameObject);
        }

        else if (collision.CompareTag("Flight"))
        {

            collision.GetComponent<EnemyHealth>().TakeDamageFlight(50);
            Destroy(gameObject);

        }
    }
}
