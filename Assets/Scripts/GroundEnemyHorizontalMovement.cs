using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundEnemyHorizontalMovement : MonoBehaviour
{
    public float speed = 2f;
    public bool left = true;

    private Rigidbody2D rbody;

    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        if (left == true)
        {
            rbody.velocity = -(Vector2)transform.right * speed;
            transform.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            rbody.velocity = (Vector2)transform.right * speed;
            transform.localScale = new Vector3(-1, 1, 1);
        }

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == ("InvisibleWall"))
        {
            left = !left;
        }
    }
}
