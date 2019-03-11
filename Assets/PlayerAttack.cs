using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{

    public Animator animator;
    public int direction;

    private void Start()
    {
        animator = GetComponent<Animator>();
        
    }

    private void Update()
    {

        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (direction == 1)
            {
                animator.SetTrigger("AttackLeft");
                animator.ResetTrigger("AttackRight");
            }
            else
            {
                animator.SetTrigger("AttackRight");
                animator.ResetTrigger("AttackLeft");
            }
        
            if (direction == 3)
            {
                animator.SetTrigger("AttackUp");
                animator.ResetTrigger("AttackRight");
            }
            
            if (direction == 4)
            {
                animator.SetTrigger("AttackDown");
                animator.ResetTrigger("AttackRight");
            }
        }

        if(Input.GetKeyDown(KeyCode.A))
        {
            animator.SetTrigger("LookLeft");
            animator.ResetTrigger("LookRight");
            direction = 1;
        }

        if(Input.GetKeyDown(KeyCode.D))
        {
            animator.SetTrigger("LookRight");
            animator.ResetTrigger("LookLeft");
            direction = 2;
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetTrigger("LookUp");
            animator.ResetTrigger("LookDown");
            direction = 3;
        }

        if(Input.GetKeyDown(KeyCode.S))
        {
            animator.SetTrigger("LookDown");
            animator.ResetTrigger("LookUp");
            direction = 4;
        }
    }
}
