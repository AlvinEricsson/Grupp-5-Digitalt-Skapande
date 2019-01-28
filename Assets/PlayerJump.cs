using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public float jumpHeight;

    public bool doubleJump = false;

    public GroundCheck groundCheck;
    private Rigidbody2D rbody;
    // Start is called before the first frame update
    void Start()
    {
       rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (groundCheck.touches > 0)
            {
                rbody.velocity = new Vector2(rbody.velocity.x, jumpHeight);
            }
        }
    }
}
