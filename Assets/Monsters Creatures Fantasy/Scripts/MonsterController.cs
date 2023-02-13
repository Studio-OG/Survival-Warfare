using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterController : MonoBehaviour
{
    private Transform MonsterPosition;
    private Animator anim;
    private int Health;



    void Start()
    {
        anim = GetComponent<Animator>();
        MonsterPosition = GetComponent<Transform>();
    }




    // Update is called once per frame
    void Update()
    {
        if (IsClosePlayer())
        {
            anim.SetBool("IsClose", true);
        }
        else
        {
            anim.SetBool("IsClose", false);
        }
    }


    bool IsClosePlayer()
    {
        if (PlayerPosition.Playerposition.position.x - MonsterPosition.position.x <= 5 &&
            PlayerPosition.Playerposition.position.x - MonsterPosition.position.x >= -5 &&
            PlayerPosition.Playerposition.position.y - MonsterPosition.position.y <= 5 &&
            PlayerPosition.Playerposition.position.y - MonsterPosition.position.y >= -5)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}