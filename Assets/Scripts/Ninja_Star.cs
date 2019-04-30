using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ninja_Star : MonoBehaviour
{
    public float trowSpeed;
    private Rigidbody2D rbody;
    public GameObject Star_Spark;

    bool enableMovemnet = true;
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
        if (collision.tag != "Player")
        {
            Instantiate(Star_Spark, transform.position, Star_Spark.transform.rotation);

            Destroy(gameObject);
        }


    }

    private void CoolDownFunction()
    {
        if (ThrowNinjaStar.coolDownTimer >= 0)
        {
            ThrowNinjaStar.coolDownTimer -= Time.deltaTime;
        }
    }

}
