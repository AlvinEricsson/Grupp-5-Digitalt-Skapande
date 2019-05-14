using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKnockback : MonoBehaviour
{

    public Rigidbody2D rb;
    public float knockbackX;
    public float knockbackY;
    public float waitForMove;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "GroundEnemy")
        {
            
            rb.GetComponent<Rigidbody2D>().velocity = new Vector2(knockbackX, knockbackY);
            Movement move = gameObject.GetComponent<Movement>();
           // move.canmove = false;
            Invoke("MoveAgain", waitForMove);
        }
    }

    void MoveAgain()
    {
        Movement move = gameObject.GetComponent<Movement>();
        //move.canmove = true;
    }
}
