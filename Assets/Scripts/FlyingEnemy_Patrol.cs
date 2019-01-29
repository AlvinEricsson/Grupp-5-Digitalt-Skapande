using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingEnemy_Patrol : MonoBehaviour
{
    public float moveSpeed = 2f;
    public bool isLeft = true;
    public bool IsMoving;

    private Rigidbody2D rbody;
    // Use this for initialization
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //horisontal movement för ett objekt
        rbody.velocity = new Vector2(moveSpeed, rbody.velocity.y);

        if (IsMoving == false)
        {
            moveSpeed *= -1;
            IsMoving = true;
        }
        if (moveSpeed < 0)
        {
            isLeft = false;
        }
        else
        {
            isLeft = true;
        }
        if (isLeft == false)
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        else
        {
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
    }
    //när den träffar en trigger så flippar objectet som har triggerat collidern
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (IsMoving == true)
        {
            IsMoving = false;
        }
        else
        {
            IsMoving = true;
        }
    }
}