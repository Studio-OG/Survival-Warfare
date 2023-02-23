using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MonsterController : MonoBehaviour
{
    private Transform MonsterPosition;
    private Animator anim;
    [SerializeField] private Transform player;
    private Rigidbody2D rb;
    private SpriteRenderer sr;
    private Vector2 hareket;
    [SerializeField] private float moveSpeed;
    private bool IsFlying;

    void Start()
    {
        anim = GetComponent<Animator>();
        MonsterPosition = GetComponent<Transform>();
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        IsFlying = true;
    }




    private void OnTriggerStay2D(Collider2D collision)
    {
        IsFlying = false;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        IsFlying = true;
    }


    // Update is called once per frame
    void Update()
    {
        #region Karakter yakýndaysa saldýrý animasyonu devreye girer
        if (IsFlying)
        {
            anim.SetBool("IsClose", false);
        }
        else
        {
            anim.SetBool("IsClose", true);
        }
        #endregion





        #region Karaktere doðru hareket et
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

        #endregion

    }





    private void FixedUpdate()
    {
        if (IsFlying == true)
        {
            MoveMonster(hareket);
        }

    }





    void MoveMonster(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
    }


}