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

    }

    void Die()
    {
        // Die
        animator.SetBool("IsDead", true);

        Debug.Log("Enemy died!");

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
            gunHealth--;

            healthBar.SetHealth(gunHealth);

            if (gunHealth <= 0)
            {
                Destroy(gameObject);
            }

           
        }

    }
}
