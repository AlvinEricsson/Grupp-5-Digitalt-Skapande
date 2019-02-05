using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEstScript : MonoBehaviour
{
    public GameObject Trowing_Star;
    public Transform trowPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            GameObject trowingStar =(GameObject)Instantiate(Trowing_Star, trowPoint.position, trowPoint.rotation);
            trowingStar.transform.localScale = transform.localScale;
        }
    }
}
