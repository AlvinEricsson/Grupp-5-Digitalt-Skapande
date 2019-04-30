using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knockback : MonoBehaviour
{
    public float thrust;
    public float knockTime;

   
 

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Rigidbody2D Enemy = GetComponent<Rigidbody2D>();
            if (Enemy != null)
            {
                Enemy.isKinematic = false;
                Vector2 difference = Enemy.transform.position - transform.position;
                difference = difference.normalized * thrust;
                Enemy.AddForce(difference + Vector2.up * thrust, ForceMode2D.Impulse);
                StartCoroutine(KnockCo(Enemy));
            }
        }
    }
    private IEnumerator KnockCo(Rigidbody2D Enemy)
    {
        if(Enemy != null)
        {
            yield return new WaitForSeconds(knockTime);
            Enemy.velocity = Vector2.zero;
            Enemy.isKinematic = true;
        }
    }
    
}
