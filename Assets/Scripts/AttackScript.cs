using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackScript : MonoBehaviour
{
    private bool attacking = false;
    private bool upAttacking = false;
    private bool downAttacking = false;

    private float attackTimer = 0;
    private float attackCD = 0.5f;
    private int direction;

    public Collider2D attackTrigger;
    public Collider2D attackTriggerUp;
    public Collider2D attackTriggerDown;

    private Animator anim;

    public GameObject swordSound;

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
                var sound = Instantiate(swordSound, transform.position, Quaternion.identity);
                Destroy(sound, 1);
                
                
            }
        }
        if (direction == 2)
        {
            if (Input.GetKeyDown(KeyCode.E) && !attacking)
            {
                upAttacking = true;
                attackTimer = attackCD;

                attackTriggerUp.enabled = true;
                var sound = Instantiate(swordSound, transform.position, Quaternion.identity);
                Destroy(sound, 1);

            }
        }
        if (direction == 3)
        {
            if (Input.GetKeyDown(KeyCode.E) && !attacking)
            {
                downAttacking = true;
                attackTimer = attackCD;

                attackTriggerDown.enabled = true;
                var sound = Instantiate(swordSound, transform.position, Quaternion.identity);
                Destroy(sound, 1);

            }
        }

        if (attacking || upAttacking || downAttacking)
        {
            if (attackTimer > 0)
            {
                attackTimer -= Time.deltaTime;
            }
            else
            {
                attacking = false;
                downAttacking = false;
                upAttacking = false;
                attackTrigger.enabled = false;
                attackTriggerUp.enabled = false;
                attackTriggerDown.enabled = false;
            }
        }
        anim.SetBool("Attacking", attacking);
        anim.SetBool("DownAttacking", downAttacking);
        anim.SetBool("UpAttacking", upAttacking);
    }
}
