using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public Animator animator;


    public int maxHealth = 100;
    int currentHealth;
    public int gunHealth = 10;

    public HealthBar healthBar;

  


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        animator = GetComponent<Animator>();
    }

    public void TakeDamage(int damage)
    {
        // hurt animasyonunu oynat

        animator.SetBool("IsHurt", true);

        if (currentHealth <= 0)
        {
            Die();
        }

        //Destroy(gameObject);

        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);

        Invoke("Deneme", 1f);

        
    }

    void Die()
    {
        // Die
        animator.SetBool("IsDead", true);
        Enemy.canMove = false;
        Debug.Log("Enemy died!");

        // Düşmanı devre dışı bırak
        GetComponent<Collider2D>().enabled = false;

        Invoke("DestroyEnemy", 3f);
        //this.enabled = false;

    }

   void DestroyEnemy()
    {
        Destroy(gameObject);
    }


    private void OnTriggerEnter2D(Collider2D col)
    {
    

        if (col.tag == "Bullet")
        {
            gunHealth--;

            healthBar.SetHealth(gunHealth);

            if (gunHealth <= 0)
            {
                Destroy(gameObject);
            }

           
        }

    }


    public void Deneme()
    {
        animator.SetBool("IsHurt", false);
    }

}
