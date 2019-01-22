 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashMove : MonoBehaviour
{
    public KeyCode dashRight;
    public KeyCode dashLeft;
    private Rigidbody2D rbody;
    public float dashSpeed;
    private float dashTime;
    public float startDashTime;
    private int direction;
    
    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        dashTime = startDashTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (direction == 0)
        {
            if(Input.GetKeyDown(dashRight) || Input.GetKey(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.D))
            {
                direction = 1;
            }
            else if(Input.GetKeyDown(dashLeft) || Input.GetKey(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.A))
            {
                direction = 2;
            }
        }
        else
        {
            if(dashTime <= 0)
            {
                direction = 0;
                dashTime = startDashTime;
                rbody.velocity = Vector2.zero;
            }
            else
            {
                dashTime -= Time.deltaTime;

                if(direction == 1)
                {
                    rbody.velocity = Vector2.right * dashSpeed;
                }
                else if(direction == 2)
                {
                    rbody.velocity = Vector2.left * dashSpeed;
                }
            }
        }
    }
}
