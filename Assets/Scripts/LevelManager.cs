using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject currentCheckpoint;

    private movement player;

    void Start()
    {
        player = FindObjectOfType<movement>();
    }

    public void RespawnPlayer()
    {
        Debug.Log("Respawn PLayer");
        player.transform.position = currentCheckpoint.transform.position;
    }
}
