using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEstScript : MonoBehaviour
{
    public GameObject Throwing_Star;
    public Transform throwPoint;
    public float coolDownTime = 2;
    private float nextThrowTime = 0;
    public int throwSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time>nextThrowTime)
        if (Input.GetKeyDown(KeyCode.Q))
        {
            GameObject trowingStar =(GameObject)Instantiate(Throwing_Star, throwPoint.position, throwPoint.rotation);
            Throwing_Star.transform.localScale = transform.localScale;
            nextThrowTime = Time.time + coolDownTime;
        }
    }
}
