using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Transform player;
    Vector2 movement;
    Transform enemyPosition;
    Rigidbody2D enemyRB;
    private Animator animator;
    SpriteRenderer enemySR;
    bool IsMoving;
    bool IsRun;
    public float minDistance = 2f;




    // Start is called before the first frame update
    void Start()
    {
        enemyPosition = GetComponent<Transform>();
        enemyRB = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        enemySR = GetComponent<SpriteRenderer>();
        IsMoving = true;

    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            IsMoving = false;

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            IsMoving = true;

        }
    }


    // Update is called once per frame
    void Update()
    {
        SetAnim();
        SetDirection();


    }


    void SetAnim()
    {
        if (movement != Vector2.zero)
        {
            animator.SetBool("IsRun", true);


        }
        else
        {

            animator.SetBool("IsRun", false);

        }



        if (IsMoving)   //saldırı animasyonu devreye girer
        {
            animator.SetBool("IsClose", false);


        }
        else
        {
            animator.SetBool("IsClose", true);

        }



    }

  




    void SetDirection()
    {
        if (movement.x < 0f)
        {
            enemySR.flipX = true;
        }
        else
        {
            enemySR.flipX = false;
        }
        Vector3 direction = ((player.position - enemyPosition.position) * minDistance);
        direction.Normalize();

        movement = direction;
    }





    private void FixedUpdate()
    {

        if (IsMoving == true)
        {
            MoveEnemy(movement);
        }


    }

    void MoveEnemy(Vector2 direction)
    {
        enemyRB.MovePosition((Vector2)transform.position + movement * speed * Time.fixedDeltaTime);
    }
}
