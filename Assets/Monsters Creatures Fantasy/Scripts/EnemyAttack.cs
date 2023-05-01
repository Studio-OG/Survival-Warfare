using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public MainCharHealth mainCharHealth;
    public Animator animator;



    private void Start()
    {
        animator = GetComponent<Animator>();
    }



    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))

        {
            animator.SetBool("IsAttack", false);
            mainCharHealth.TakeDamage(1);

        }


    }











}



