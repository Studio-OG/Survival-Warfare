using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public Animator animator;

    public int maxHealth = 100;
    public int currentHealth;
    public int gunHealth = 10;
    public GameObject coin; 
    public HealthBar healthBar;
    private CoinController coinController;
    private void Update()
    {
        healthBar.SetHealth(currentHealth);
    }

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        animator = GetComponent<Animator>();
        coinController = GameObject.Find("CoinController").GetComponent<CoinController>();
    }

    public void TakeDamage(int damage)
    {
        // hurt animasyonunu oynat

        animator.SetBool("IsHurt", true);

        if (currentHealth <= 0)
        {
            ScoreAndHealth.totalScore += 10;
            Die();
        }

        //Destroy(gameObject);

        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);

        Invoke("Deneme", 1f); 
    }

    public void TakeDamageFlight(int damage)
    {
        // hurt animasyonunu oynat

        animator.SetBool("IsTakeHit", true);
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            ScoreAndHealth.totalScore += 10;
            DieFlight();
        }
        //Destroy(gameObject);


        healthBar.SetHealth(currentHealth);

        Invoke("DenemeFlight", 1f);
    }

    void Die()
    {
        // Die
        animator.SetBool("IsDead", true);
        gameObject.GetComponent<Enemy>().canMove = false;
        Debug.Log("Enemy died!");

        // Düşmanı devre dışı bırak
        GetComponent<Collider2D>().enabled = false;

        Invoke("DestroyEnemy", 1f);
        //this.enabled = false;

    }

    void DieFlight()
    {
        // Die
        animator.SetBool("IsDead", true);
        // Düşmanı devre dışı bırak
        GetComponent<Collider2D>().enabled = false;

        Invoke("DestroyEnemy", 1f);
        //this.enabled = false;

    }

    void DestroyEnemy()
    {
        coinController.InstantiateCoin(coin, transform.position);
        Destroy(gameObject);
    }


    public void Deneme()
    {
        animator.SetBool("IsHurt", false);
    }

    public void DenemeFlight()
    {
        animator.SetBool("IsTakeHit", false);
    }

}
