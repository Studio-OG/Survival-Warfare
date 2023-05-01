using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public Animator animator;
    public int maxHealth = 100;
    private int currentHealth;
    private int gunDamage = 10;
    private CoinController coinController;
    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        animator = GetComponent<Animator>();
        coinController = GetComponent<CoinController>();
    }

    public void TakeDamage(int damage)
    {
        // hurt animasyonunu oynat

        animator.SetBool("IsHurt", true);

        if (currentHealth <= 0)
        {
            Die();
        }

        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);

        Invoke("Deneme", 1f);


    }

    void Die()
    {
        // Die
        animator.SetBool("IsDead", true);
        gameObject.GetComponent<Enemy>().canMove = false;
        Debug.Log("Enemy died!");

        // Düşmanı devre dışı bırak
        GetComponent<Collider2D>().enabled = false;

        Invoke("DestroyEnemy", 3f);
        
    }

    void DestroyEnemy()
    {
        Destroy(gameObject);
    }


    private void OnTriggerEnter2D(Collider2D col)
    {

        if (col.tag == "Bullet")
        {
            currentHealth -= gunDamage;

            healthBar.SetHealth(currentHealth);

            if (currentHealth <= 0)
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
