using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnBlueCheckpoint : MonoBehaviour
{
    private SpriteRenderer rend;
    public Sprite Blue_flag;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")

            rend.sprite = Blue_flag;
    }
}
