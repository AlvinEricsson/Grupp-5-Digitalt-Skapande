using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowNinjaStar : MonoBehaviour
{
    public static float coolDown;
    public static float coolDownTimer;
    public GameObject Throwing_Star;
    public Transform throwPoint;
    // Start is called before the first frame update
    void Start()
    {
        coolDownTimer = coolDown;
    }

    // Update is called once per frame
    void Update()
    {

        CoolDownFunction();
      
        if (Input.GetKeyDown(KeyCode.Q) && coolDownTimer <= 0)
        {
          
            CanShoot();
        }
    }

    private void CoolDownFunction()
    {
        if (coolDownTimer >= 0)
        {
            coolDownTimer -= Time.deltaTime;
        }
    }

    private void CanShoot()
    {
        coolDownTimer = coolDown;
        Debug.Log("Hej");
        GameObject trowingStar = Instantiate(Throwing_Star, throwPoint.position, throwPoint.rotation);
        trowingStar.transform.localScale = transform.localScale;
    }

}
