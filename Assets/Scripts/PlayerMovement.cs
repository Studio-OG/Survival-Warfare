using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed;


    Vector3 mousePosition;
    Vector2 movement;
    //Vector2 position = new Vector2(0f, 0f);

    Rigidbody2D playerRB;
    Animator playerAnim;
    SpriteRenderer playerSR;


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
        //mousePosition = Input.mousePosition;
        //mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        //position = Vector2.Lerp(transform.position, mousePosition, speed);
    }

    void SetAnim()
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

    void SetDirection()
    {
        if (movement.x < 0f)     //mouse a gerek varsa position olarak değiştir
        {
            playerSR.flipX = true;
        }
        else
        {
            playerSR.flipX = false;
        }

    }

    void OnMovement(InputValue value)
    {
        movement = value.Get<Vector2>();
    }
}
