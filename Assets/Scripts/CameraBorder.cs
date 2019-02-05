using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBorder : MonoBehaviour
{
    public bool border;

    public float maxX;
    public float minX;

    public float maxY;
    public float minY;

    public float Z = -10;

    void Start()
    {
        
    }

    void Update()
    {
        if(border==true)
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, minX, maxX), Mathf.Clamp(transform.position.y, minY, maxY), transform.position.z);
        }
    }
}
