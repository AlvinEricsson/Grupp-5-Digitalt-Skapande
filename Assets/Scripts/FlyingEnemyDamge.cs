using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FlyingEnemyDamage : MonoBehaviour
{
    public int health;
    private void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.gameObject.tag == "Player")
        {
            health = 3 - health;
            Debug.Log("You took damage!");
        }




    }
}
