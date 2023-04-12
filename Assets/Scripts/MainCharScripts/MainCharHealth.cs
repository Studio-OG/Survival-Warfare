using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharHealth : MonoBehaviour
{
    public Animator animator;

    public int maxHealth = 100;
    public int currentHealth;

    public HealthBar healthBar;



    

    void Start()

    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        animator = GetComponent<Animator>();
    }




    void Update()

    {

       

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

        healthBar.SetHealth(currentHealth); 

        

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








