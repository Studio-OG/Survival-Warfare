using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainCharHealth : MonoBehaviour
{

    public Animator animator;

    public int maxHealth = 100;
    public int currentHealth;
    public HealthBar healthBar;
    public Animator enemyAnim;
    public bool gameOver = false;
    private MainCharMovement mainCharMovementScript;

    private void Update()
    {
        healthBar.SetHealth(currentHealth);
        if (currentHealth <= 0)
        {
            Die();
        }
    }
    void Start()

    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        animator = GetComponent<Animator>();
        mainCharMovementScript = GameObject.FindGameObjectWithTag("Player").GetComponent<MainCharMovement>();
    }


    public void TakeDamage(int damage)

    {

        //if (enemyAnim.GetBool("IsClose") && !animator.GetBool("IsAttack"))
        //{

            animator.SetBool("IsHurt", true);

            currentHealth -= damage;

            healthBar.SetHealth(currentHealth);

            if (currentHealth <= 0)
            {
                Die();

            }
       // }

        Invoke("Deneme", 0.5f);

    }


    public void Die()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Deneme()
    {
        animator.SetBool("IsHurt", false);
    }

}








