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

            TakeDamage(5);

        }

    }

    private void EnemyHit(Collider2D other)

    {

        if (other.CompareTag("Enemy"))

        {

            TakeDamage(5);

        }

    }

    public void TakeDamage(int damage)

    {

        animator.SetTrigger("Hurt");

        if (currentHealth <= 0)
        {
            Die();
        }
        //Destroy(gameObject);

        currentHealth -= damage;

        

    }
    void Die()
    {
        Debug.Log("Player died!");

        // Die
        animator.SetBool("IsDead", true);

        

    }
}








