using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    [SerializeField]
    GameObject arrow;
    public Arrow arrowscript;

    float fireRate;
    float nextFire;


    void Start()
    {
        fireRate = 2f;
        nextFire = Time.time;
        //arrow.transform.Rotate(0, 0, -90);
    }


    void Update()
    {
        CheckIfTimeToFire();
    }

    void CheckIfTimeToFire()
    {
        if (Time.time > nextFire)
        {
            Instantiate(arrow, transform.position, Quaternion.identity);
            nextFire = Time.time + fireRate;
        }
    }
}
