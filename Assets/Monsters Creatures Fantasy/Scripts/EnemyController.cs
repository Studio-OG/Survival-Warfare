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
    Animator enemyAnim;
    SpriteRenderer enemySR;
    bool IsRun;






    // Start is called before the first frame update
    void Start()
    {
        enemyPosition = GetComponent<Transform>();
        enemyRB = GetComponent<Rigidbody2D>();
        enemyAnim = GetComponent<Animator>();
        enemySR = GetComponent<SpriteRenderer>();

    }





    // Update is called once per frame
    void Update()
    {
        SetAnim();
        SetDirection();

    }


    void SetAnim()
    {
        if (IsRun)
        {
            enemyAnim.SetBool("IsClose", true);
        }
        else
        {
            enemyAnim.SetBool("IsClose", false);
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
        Vector3 direction = player.position - enemyPosition.position;
        direction.Normalize();

        movement = direction;
    }


    private void OnTriggerStay2D(Collider2D collision)
    {
   
            IsRun = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {

            IsRun = false;
        
       
    }


    private void FixedUpdate()
    {

        enemyRB.MovePosition((Vector2)transform.position + movement * speed * Time.fixedDeltaTime);


    }
}
