using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ninja_Star : MonoBehaviour
{
    public float throwSpeed;
    private Rigidbody2D rbody;
    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rbody.velocity = new Vector2(throwSpeed*transform.localScale.x, 0f);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);
    }
}
