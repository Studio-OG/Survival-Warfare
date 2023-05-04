using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MonsterController : MonoBehaviour
{
    private Transform MonsterPosition;
    private Animator anim;
    private Transform player;
    private Rigidbody2D rb;
    private SpriteRenderer sr;
    private Vector2 hareket;
    [SerializeField] private float moveSpeed;
    private bool IsFlying;
    private EnemyHealth enemyHealth;

    private MainCharHealth mainCharHealth;

    void Start()
    {
        player = GameObject.FindWithTag("Player").GetComponent<Transform>();
        mainCharHealth = GameObject.FindWithTag("Player").GetComponent<MainCharHealth>();
        anim = GetComponent<Animator>();
        MonsterPosition = GetComponent<Transform>();
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        enemyHealth = GetComponent<EnemyHealth>();
        IsFlying = true;
    }




    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            IsFlying = false;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            IsFlying = true;
        }
    }


    // Update is called once per frame
    void Update()
    {
        #region Karakter yak?ndaysa sald?r? animasyonu devreye girer
        if (IsFlying)
        {
            anim.SetBool("IsClose", false);
        }
        else
        {
            anim.SetBool("IsClose", true);
        }
        #endregion

        Debug.Log(enemyHealth.currentHealth);




        #region Karaktere do?ru hareket et
        if (enemyHealth.currentHealth > 0)
        {
            Vector3 direction = player.position - MonsterPosition.position;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            if (direction.x <= 0)
            {
                sr.flipY = true;
            }
            else
            {
                sr.flipY = false;
            }
            rb.rotation = angle;
            direction.Normalize();
            hareket = direction;
        }
        #endregion

    }





    private void FixedUpdate()
    {
        if (IsFlying == true && enemyHealth.currentHealth > 0)
        {
            MoveMonster(hareket);
        }

    }





    void MoveMonster(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
    }
    public void Attack()
    {
        mainCharHealth.currentHealth -= 10;
        Debug.Log("kuþvurdu");
    }

}


