using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public float moveSpeed = 7f;
    public float speed = 5f;
    public bool freezeRotation;
    public Health_Player health;
    
    public Transform target;
    Rigidbody2D rb;

    Vector2 moveDirection;
    public Quaternion rotation;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindWithTag("Player").transform;
        moveDirection = (target.transform.position - transform.position).normalized;

        float ang = Mathf.Atan2(moveDirection.y, moveDirection.x) * Mathf.Rad2Deg;

        rb.velocity = moveDirection * moveSpeed;
        transform.rotation = Quaternion.Euler(0, 0, ang);
        Destroy(gameObject, 3f);
        freezeRotation = false;
        
        

        //rb.velocity = transform.forward * 100;
    }

    public void Update()
    {
        //Vector2 direction = targetx.position - transform.position;
        //float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        //rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        //transform.rotation = Quaternion.Slerp(transform.rotation, rotation, speed * Time.deltaTime);
    }

    void OnCollisionEnter2D (Collision2D col)
    {
        if(col.gameObject.name.Equals("Player"))
        {
            Debug.Log("Hit!");
            Destroy(gameObject);
            
        }

        if(col.gameObject.tag.Equals("Ground"))
        {
            freezeRotation = true; 
        }
    }
}
