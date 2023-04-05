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

   



    private void OnTriggerEnter2D(Collider2D other)
    {

        animator.SetBool("IsAttack", false);

        if (other.gameObject.CompareTag("Player"))

        {

            mainCharHealth.TakeDamage(10);

        }

      
    }




    //if (IsMoving)   //saldırı animasyonu devreye girer
    //{
    //    animator.SetBool("IsClose", false);


    //}
    //else
    //{
    //    animator.SetBool("IsClose", true);

    //}









}



