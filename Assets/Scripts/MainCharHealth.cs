using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharHealth : MonoBehaviour
{
    public Animator animator;

   
    public int maxHealth = 15;

    public int currentHealth;

    

    void Start()

    {

        currentHealth = maxHealth;
        animator = GetComponent<Animator>();
    }




    void Update()

    {

        if (Input.GetMouseButtonDown(1))

        {

            TakeDamage(10);

        }

    }

     public void EnemyHit(Collider2D other)

    {

        if (other.CompareTag("Enemy"))

        {

            TakeDamage(10);
            
        }

    }

    public void TakeDamage(int damage)

    {

        animator.SetBool("IsHurt", true);

        if (currentHealth <= 0)
        {
            Die();
        }
        //Destroy(gameObject);

        currentHealth -= damage;

        

    }
    void Die()
    {
        

        // Die
        animator.SetBool("IsDead", true);

        Debug.Log("Player died!");
        GetComponent<Collider2D>().enabled = false;
        this.enabled = false;
    }
}








