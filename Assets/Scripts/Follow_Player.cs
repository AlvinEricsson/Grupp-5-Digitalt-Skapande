using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow_Player : MonoBehaviour
{
    private Transform target;
    public float speed;
    public bool followNow;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        followNow = false;
    }

    void Update()
    {
        FollowPlayer();
    }

    public void FollowPlayer()
    {
        if (followNow == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
      
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            followNow = true;
        }
    }
}
