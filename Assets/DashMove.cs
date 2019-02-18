using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashMove : MonoBehaviour
{
    //Dash Forward
    public static KeyCode dashRight;
    public static KeyCode dashLeft;
    private Rigidbody2D rbody;
    public float dashSpeed;
    private float dashTime;
    public float startDashTime;
    public int direction;
    public int dashes;
    public groundCheck gCheck;
    public static bool disableMovement = false;

    //Cooldown
    public bool isDashing = false;

    // Start is called before the first frame update
    void Start()
    {
        //Dash Forward
        rbody = GetComponent<Rigidbody2D>();
        dashTime = startDashTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (isDashing == false && dashes >= 1)
        {
            disableMovement = true;
            if (Input.GetKey(dashRight) || Input.GetKey(KeyCode.D))
            {
                direction = 1;
            }

            if (Input.GetKey(dashLeft) || Input.GetKey(KeyCode.A))
            {
                direction = 2;
            }

            if (Input.GetKey(KeyCode.LeftShift))
            {
                isDashing = true;
                dashes = 0;
            }

        }
        else
        {
            if (dashTime <= 0) //Checks if finished dashing.
            {
                direction = 0;
                dashTime = startDashTime;
                rbody.velocity = Vector2.zero;
                isDashing = false;
            }
            else if(isDashing)
            {
                dashTime -= Time.deltaTime;

                if (direction == 1)
                {
                    rbody.velocity = Vector2.right * dashSpeed;
                }

                if (direction == 2)
                {
                    rbody.velocity = Vector2.left * dashSpeed;
                }
            }
            disableMovement = false;
        }

        if (gCheck.isGrounded >= 1)
        {
            dashes = 1;
        }
    }
}



