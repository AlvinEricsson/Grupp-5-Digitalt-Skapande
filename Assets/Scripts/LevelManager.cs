using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject currentCheckpoint;

    private Movement player;

    void Start()
    {
        player = FindObjectOfType<Movement>();
    }

    public void RespawnPlayer()
    {
        Debug.Log("Respawn PLayer");
        player.transform.position = currentCheckpoint.transform.position;
    }
}
