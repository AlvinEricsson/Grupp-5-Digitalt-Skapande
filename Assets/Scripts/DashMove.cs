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
    private int direction;

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
        if (isDashing == false)
        {

            if (Input.GetKeyDown(dashRight) || Input.GetKeyDown(KeyCode.D))
            {
                direction = 1;
            }
            else if (Input.GetKeyDown(dashLeft) || Input.GetKeyDown(KeyCode.A))
            {
                direction = 2;
            }
            if (Input.GetKey(KeyCode.LeftShift))
            {
                isDashing = true;
            }
        }
        else
        {
            if (dashTime <= 0)
            {
                direction = 0;
                dashTime = startDashTime;
                rbody.velocity = Vector2.zero;
                isDashing = false;
            }
            else
            {
                dashTime -= Time.deltaTime;

                if (direction == 1)
                {
                    rbody.velocity = Vector2.right * dashSpeed;
                }
                else if (direction == 2)
                {
                    rbody.velocity = Vector2.left * dashSpeed;
                }
            }

        }


    }












}

  

