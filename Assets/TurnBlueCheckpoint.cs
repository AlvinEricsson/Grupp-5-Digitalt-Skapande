using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnBlueCheckpoint : MonoBehaviour
{
    public SpriteRenderer rend;
    public Sprite Blue_flag;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")

            rend.sprite = Blue_flag;
    }
}
