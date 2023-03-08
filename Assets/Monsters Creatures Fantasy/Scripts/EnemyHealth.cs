using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public Animator animator;


    public int maxHealth = 100;
    int currentHealth;



    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        // hurt animasyonunu oynat

        animator.SetTrigger("Hurt");

        if (currentHealth <= 0)
        {
            Die();
        }
        //Destroy(gameObject);
    }

    void Die()
    {
        Debug.Log("Enemy died!");

        // Die
        animator.SetBool("IsDead", true);

        // Düşmanı devre dışı bırak
        GetComponent<Collider2D>().enabled = false;
        this.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {


    }


    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Bullet")
        {
            currentHealth--;


        }

    }
}
