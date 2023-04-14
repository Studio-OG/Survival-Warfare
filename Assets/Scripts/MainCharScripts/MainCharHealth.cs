using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharHealth : MonoBehaviour
{
    private bool takeDamage;

    public Animator animator;

    public int maxHealth = 100;
    public int currentHealth;

    public HealthBar healthBar;

    public Animator enemyAnim;

   


    

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
        takeDamage = true;

        if (takeDamage && !animator.GetBool("IsAttack"))
        {
            animator.SetBool("IsHurt", true);

            currentHealth -= damage;

            healthBar.SetHealth(currentHealth);

            if (currentHealth <= 0)
            {
                Die();
            }
        }
        else
        {
            animator.SetBool("IsHurt", false);
        }
        


        //Destroy(gameObject);


    }


    void Die()
    {
       
        // Die
        Debug.Log("Player died!");

        animator.SetBool("IsDead", true);
        enemyAnim.SetBool("IsRun", false);


        GetComponent<Collider2D>().enabled = false;

        this.enabled = false;
    }
}








