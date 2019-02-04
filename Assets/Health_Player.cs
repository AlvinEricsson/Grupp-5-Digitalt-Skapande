using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health_Player : MonoBehaviour
{
    public float health;
    public int numOfHearts;
    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;
    public string chosenscene;

    private void Update()
    {
        if (health > numOfHearts)
        {
            health = numOfHearts;
        }


        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < health)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }
            if (i < numOfHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }





        }
        if (health < 1)
        {
            Debug.Log("Du dog");


            //Den här gör så att när något rör objectet där detta scriptet är på laddas en ny scene som jag har bestämt i unity


            SceneManager.LoadScene(chosenscene);

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Hp_Pick_Up")
        {
            health = 0.5f + health;
            Debug.Log("Hello world");
            Destroy(collision.gameObject);
        }
    }
}


