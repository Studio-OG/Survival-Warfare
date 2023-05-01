using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    [SerializeField] float speed;
    private Transform player;
    Vector2 movement;
    Transform enemyPosition;
    Rigidbody2D enemyRB;
    private Animator animator;
    SpriteRenderer enemySR;
    public bool canMove = true;
    private Animator playerAnim;
    

    public MainCharHealth mainCharHealth;



    // Start is called before the first frame update
    void Start()
    {
        enemyPosition = GetComponent<Transform>();
        enemyRB = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        enemySR = GetComponent<SpriteRenderer>();
        player = GameObject.FindWithTag("Player").GetComponent<Transform>();
        playerAnim = GameObject.FindWithTag("Player").GetComponent<Animator>();
    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            canMove = false;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && !animator.GetBool("IsDead"))
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



        if (movement != Vector2.zero && canMove && !playerAnim.GetBool("IsDead"))
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
        if (canMove == true && !playerAnim.GetBool("IsDead"))
        {
            Debug.Log("koşuyor");

            EnemyMove(movement);
        }
    }



    private void EnemyMove(Vector2 direction)
    {
        enemyRB.MovePosition((Vector2)transform.position + (direction * speed * Time.deltaTime));
    }



    public void Attack()
    {
        Debug.Log("Saldırı yapıldı");
        mainCharHealth.TakeDamage(10);
    }
}
