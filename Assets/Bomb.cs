using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public Rigidbody2D rbody;
    public float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(rbody.gravityScale == 1)
        {
            timer = timer + 1 * Time.deltaTime;
        }

        if(timer > 3)
        {
            //explodera
            Debug.Log("boom");
            Destroy(gameObject);
        }
    }
}
