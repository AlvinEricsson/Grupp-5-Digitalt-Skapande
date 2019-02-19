using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEstScript : MonoBehaviour
{
    public GameObject Throwing_Star;
    public Transform throwPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            GameObject trowingStar =(GameObject)Instantiate(Throwing_Star, throwPoint.position, throwPoint.rotation);
            trowingStar.transform.localScale = transform.localScale;
        }
    }
}
