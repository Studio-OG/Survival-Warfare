using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MainCharMovement : MonoBehaviour
{


    [SerializeField] public float speed;


    Vector2 movement;

    Rigidbody2D playerRB;
    public Animator playerAnim;
    SpriteRenderer playerSR;
   
    bool canMove = true;

    public GameObject crossHair;


    


    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
        playerAnim = GetComponent<Animator>();
        playerSR = GetComponent<SpriteRenderer>();

    }




    private void FixedUpdate()
    {


        playerRB.velocity = movement * speed;

    }

    void Update()
    {
        SetAnim();
        SetDirection();
    }

    void SetAnim()
    {
        if (canMove)
        {
            if (playerRB.velocity != Vector2.zero)
            {
                playerAnim.SetBool("IsRun", true);
            }
            else
            {
                playerAnim.SetBool("IsRun", false);

            }
        }

    }

    void SetDirection()
    {

        if (canMove)
        {
            if (movement.x <= 0f)
            {
                playerSR.flipX = true;
            }
            else
            {
                playerSR.flipX = false;
            }
        }
    }

    

    void OnMovement(InputValue value)
    {
        movement = value.Get<Vector2>();
    }





}









  