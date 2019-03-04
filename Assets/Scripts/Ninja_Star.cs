using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ninja_Star : MonoBehaviour
{
    public float trowSpeed;
    private Rigidbody2D rbody;
    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rbody.velocity = new Vector2(trowSpeed * transform.localScale.x, 0f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "GroundEnemy")
        {
            Destroy(gameObject);
        }
    }


}
