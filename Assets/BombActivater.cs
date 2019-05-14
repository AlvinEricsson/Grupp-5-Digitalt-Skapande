using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombActivater : MonoBehaviour
{
    public Rigidbody2D bomb;

    private void Start()
    {
        bomb.gravityScale = 0;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
       
            bomb.gravityScale = 1;
            Destroy(gameObject);

        }
      

    }
}
