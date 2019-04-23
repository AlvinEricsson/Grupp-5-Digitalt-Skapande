using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackScript : MonoBehaviour
{
    private bool attacking = false;

    private float attackTimer = 0;
    private float attackCD = 0.3f;
    private int direction;

    public Collider2D attackTrigger;
    public Collider2D attackTriggerUp;
    public Collider2D attackTriggerDown;

    private Animator anim;

    void Awake()
    {
        anim = gameObject.GetComponent<Animator>();
        attackTrigger.enabled = false;
        attackTriggerUp.enabled = false;
        attackTriggerDown.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            direction = 1;
        }    
        if (Input.GetKeyDown(KeyCode.D))
        {
           direction = 1;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            direction = 2;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            direction = 3;
        }




        if (direction == 1)
        {
            if (Input.GetKeyDown(KeyCode.E) && !attacking)
            {
                attacking = true;
                attackTimer = attackCD;

                attackTrigger.enabled = true;
            }
        }
        if (direction == 2)
        {
            if (Input.GetKeyDown(KeyCode.E) && !attacking)
            {
                attacking = true;
                attackTimer = attackCD;

                attackTriggerUp.enabled = true;
            }
        }
        if (direction == 3)
        {
            if (Input.GetKeyDown(KeyCode.E) && !attacking)
            {
                attacking = true;
                attackTimer = attackCD;

                attackTriggerDown.enabled = true;
            }
        }

        if (attacking)
        {
            if (attackTimer > 0)
            {
                attackTimer -= Time.deltaTime;
            }
            else
            {
                attacking = false;
                attackTrigger.enabled = false;
                attackTriggerUp.enabled = false;
                attackTriggerDown.enabled = false;
            }
        }
        anim.SetBool("Attacking", attacking);
    }
}
