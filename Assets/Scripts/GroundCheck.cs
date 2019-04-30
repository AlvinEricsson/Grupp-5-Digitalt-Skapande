using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    [SerializeField]
    GameObject dustCloud;

    public int isGrounded;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = isGrounded + 1;
<<<<<<< HEAD

            Instantiate(dustCloud, transform.position, dustCloud.transform.rotation);

=======
>>>>>>> MovingPLatform
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
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
