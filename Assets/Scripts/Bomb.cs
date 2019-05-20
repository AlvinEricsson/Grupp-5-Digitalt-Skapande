using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public GameObject hitbox;
    public static Animator anim;
    public Rigidbody2D rbody;
    public float timer;
    // Start is called before the first frame update
    void Start()
    {
        
        anim = GetComponent<Animator>();
        anim.SetBool("IsWaiting", true);
    }

    // Update is called once per frame
    void Update()
    {
        if(rbody.gravityScale == 1)
        {
            Debug.Log("Waiting false");
            anim.SetBool("IsWaiting", false);
            timer = timer + 1 * Time.deltaTime;
        }

        if(timer > 3)
        {
            hitbox.SetActive(true);
            Debug.Log("boom");
        }
        if(timer > 3.3f)
        {
            Destroy(gameObject);

        }
    }
}
