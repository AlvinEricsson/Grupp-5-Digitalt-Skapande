using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow_Player : MonoBehaviour
{
    private Transform target;
    public float speed;
    public bool followNow;

    public bool facingRight = false;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        followNow = false;



    }

    void Update()
    {
        FollowPlayer();
        if (target.transform.position.x < gameObject.transform.position.x && facingRight)
            Flip();
        if (target.transform.position.x > gameObject.transform.position.x && !facingRight)
            Flip();


    }

    public void FollowPlayer()
    {
        if (followNow == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            //transform.LookAt(target);


            //transform.localScale *= -1f;


        }

    }
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            followNow = true;
        }
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 tmpScale = gameObject.transform.localScale;
        tmpScale.x *= -1;
        gameObject.transform.localScale = tmpScale;
    }
}
