using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
  

    public MainCharHealth mainCharHeath;
    

    private void OnTriggerEvent(Collider other)

    {

        if (other.gameObject.CompareTag("Player"))

        {

            mainCharHeath.TakeDamage(5);

        }

    }















}



