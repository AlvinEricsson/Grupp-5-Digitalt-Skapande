using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knockback : MonoBehaviour
{
    public float thrust;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("GroundEnemy"))
        {
            Rigidbody2D GroundEnemy = other.GetComponent<Rigidbody2D>();
            if(GroundEnemy != null)
            {
                GroundEnemy.isKinematic = false;
                Vector2 difference = GroundEnemy.transform.position - transform.position;
                difference = difference.normalized * thrust;
                GroundEnemy.AddForce(difference, ForceMode2D.Impulse);
                GroundEnemy.isKinematic = true;
            }
        }
    }

}
