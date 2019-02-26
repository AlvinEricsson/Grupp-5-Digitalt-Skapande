using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class KillPlayer : MonoBehaviour
{
    public LevelManager levelManager;

    // Start is called before the first frame update
    void Start()
    {
        levelManager = FindObjectOfType<LevelManager>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "player")
        {
            levelManager.RespawnPlayer();
        }
    }
}
