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
    public Animator animator;
    SpriteRenderer enemySR;
    bool canMove = true;
    //bool IsClose = true;
    
    public float minDistance = 2f;



    public MainCharHealth mainCharHealth;


    // Start is called before the first frame update
    void Start()
    {
        enemyPosition = GetComponent<Transform>();
        enemyRB = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        enemySR = GetComponent<SpriteRenderer>();
        
    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            animator.SetBool("IsAttack", true);

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {


            animator.SetBool("IsAttack", false);

            mainCharHealth.TakeDamage(10);

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


        if (canMove)
        {
            if (movement != Vector2.zero)
            {
                animator.SetBool("IsRun", true);


            }
            else
            {

                animator.SetBool("IsRun", false);

            }
        }
        

    }

  




    void SetDirection()
    {
        if (canMove)
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
        
    }





    private void FixedUpdate()
    {

       
        {
            MoveEnemy(movement);
        }


    }

    void MoveEnemy(Vector2 direction)
    {
        enemyRB.MovePosition((Vector2)transform.position + (direction * speed * Time.fixedDeltaTime));
    }
}
