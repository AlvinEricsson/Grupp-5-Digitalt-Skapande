using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundCheck : MonoBehaviour
{
    public int isGrounded;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = isGrounded + 1;

        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = isGrounded - 1;
        }
    }

   // private void OnCollisionStay2D(Collision2D collision)
   // {
        //DashMove.dashes = 0;
  //  }

}
