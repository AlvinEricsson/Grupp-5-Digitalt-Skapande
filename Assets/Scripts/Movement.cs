﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    
    public float moveSpeed;
    Rigidbody2D rbody;
    private Animator anim;
    public GroundCheck groundCheck;
    public float jumpSpeed;
    private float dirX;

    public float knockback;
    public float knockbackLength;
    public float knockbackCount;
    public bool knockFromRight;


    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        dirX = Input.GetAxisRaw("Horizontal") * moveSpeed;

        if (Mathf.Abs(dirX) > 0 && rbody.velocity.y == 0)
        { 
            anim.SetBool("IsRunning", true);
        }
        else
        {
            anim.SetBool("IsRunning", false);
        }

        if (rbody.velocity.y == 0)
        {
            anim.SetBool("IsJumping", false);
            anim.SetBool("IsFalling", false);
        }

        if (rbody.velocity.y > 0)
        {
            anim.SetBool("IsJumping", true);
        }

        if (rbody.velocity.y < 0)
        {
            anim.SetBool("IsJumping", false);
            anim.SetBool("IsFalling", true);
        }


        if (DashMove.disableMovement == true)
        {
            rbody.velocity = new Vector2(Input.GetAxis("Horizontal") * moveSpeed, rbody.velocity.y);
            if (Input.GetButtonDown("Jump"))
            {
                if (groundCheck.isGrounded > 0)
                {
                    rbody.velocity = new Vector2(rbody.velocity.x, jumpSpeed);
                }
            }

            if(Input.GetKeyDown(KeyCode.A))
                {
                transform.localScale = new Vector3(-1, 1, 1);
            }

            if(Input.GetKeyDown(KeyCode.D))
            {
                transform.localScale = new Vector3(1, 1, 1);
            }
        }

        if (knockbackCount <= 0)
        {
            if (DashMove.disableMovement == true)
            {
                rbody.velocity = new Vector2(Input.GetAxis("Horizontal") * moveSpeed, rbody.velocity.y);

                if (Input.GetButtonDown("Jump"))
                {
                    if (groundCheck.isGrounded > 0)
                    {
                        rbody.velocity = new Vector2(rbody.velocity.x, jumpSpeed);
                    }
                }
            }
        }

    }
    

        






    

}
