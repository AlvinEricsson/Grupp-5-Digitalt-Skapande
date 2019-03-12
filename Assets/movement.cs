using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float mSpeed;
    Rigidbody2D rbody;
    public groundCheck groundCheck;
    public float jumpSpeed;

    public float knockback;
    public float knockbackLength;
    public float knockbackCount;
    public bool knockFromRight;

    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {


        if (knockbackCount <= 0)
        {
            if (DashMove.disableMovement == true)
            {
                rbody.velocity = new Vector2(Input.GetAxis("Horizontal") * mSpeed, rbody.velocity.y);

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
