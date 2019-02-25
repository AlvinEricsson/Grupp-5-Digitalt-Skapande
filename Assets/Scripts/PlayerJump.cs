using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public float jumpHeight;

    public GroundCheck groundCheck;
    private Rigidbody2D rbody;

    void Start()
    {
       rbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (groundCheck.isGrounded > 0)
            {
                rbody.velocity = new Vector2(rbody.velocity.x, jumpHeight);
            }
        }
    }
}
