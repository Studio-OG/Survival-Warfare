using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharAttack : MonoBehaviour
{
    public Animator playerAnim;
    public Transform attackPoint;
    public LayerMask enemyLayers;

    public float attackRange = 0.5f;
    public int attackDamage = 40;

    public float attackRate = 2f;
    float nextAttackTime = 0f;


    private bool canAttack = true;


    private void Start()
    {
        playerAnim = GetComponent<Animator>();
    }






    // Update is called once per frame
    void Update()
    {
        Attack();
    }


    void Attack()
    {
        if (canAttack && Input.GetMouseButton(1))
        {

            playerAnim.SetBool("IsAttack", true);

            // Attack range (saldırı menzili)  in içine girecek düşmanları belirle ve bunları hitEnemies içerisinde depola
            Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

            // Düşmanlara zarar ver
            foreach (Collider2D enemy in hitEnemies)
            {
                enemy.GetComponent<EnemyHealth>().TakeDamage(20);

            }


        }
        else
        {
            playerAnim.SetBool("IsAttack", false);
        }


    }



    private void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return;

        //Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }


}



