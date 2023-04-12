using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    [SerializeField] float speed;
    [SerializeField] Transform player;
    Vector2 movement;
    Transform enemyPosition;
    Rigidbody2D enemyRB;
    private Animator animator;
    SpriteRenderer enemySR;
    private bool canMove = true;
    


    public MainCharHealth mainCharHealth;



    // Start is called before the first frame update
    void Start()
    {
        enemyPosition = GetComponent<Transform>();
        enemyRB = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        enemySR = GetComponent<SpriteRenderer>();
    }


    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            canMove = false;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            canMove = true;
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            animator.SetBool("IsClose", false); // atak animasyonunu durdur
        }
        else
        {
            animator.SetBool("IsClose", true); // atak animasyonunu başlat
        }



        if (movement != Vector2.zero)
        {
            animator.SetBool("IsRun", true);


        }
        else
        {

            animator.SetBool("IsRun", false);

        }




        if (movement.x <= 0f)
        {
            enemySR.flipX = true;
        }
        else
        {
            enemySR.flipX = false;
        }

        Vector3 direction = (player.position - enemyPosition.position);

        direction.Normalize();

        movement = direction;



    }


    private void FixedUpdate()
    {
        if (canMove == true)
        {
            EnemyMove(movement);
        }
    }



    void EnemyMove(Vector2 direction)
    {
        enemyRB.MovePosition((Vector2)transform.position + (direction * speed * Time.deltaTime));
    }



    public void Attack()
    {
        Debug.Log("Saldırı yapıldı");
    }
}