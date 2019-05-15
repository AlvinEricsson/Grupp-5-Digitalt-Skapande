using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Victory : MonoBehaviour
{
    public GameManager gameMaster;
    public SpriteRenderer rend;
    public Sprite sprite;
    public float timer;
    public string chosenScene;
    public bool win;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
            gameMaster.CompleteLevel();
            rend.sprite = sprite;
        win = true;
    }
    private void Update()
    {
        if (win == true)
        {
            timer = timer + Time.deltaTime;
        }
        if (timer > 4f)
        {
            SceneManager.LoadScene(chosenScene);
        }
    }

}
