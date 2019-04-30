using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health_Player : MonoBehaviour
{
    public float coolDown = 3;
    public float coolDownTimer;

    public GameObject soundPickup;
    public GameObject soundDamageTaken;

    public float health;
    public int numOfHearts;
    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;
    public string chosenscene;
    public CameraShake cameraShake;

    private void Start()
    {
        coolDownTimer = coolDown;
    }
    private void Update()
    {
        CoolDownFunction();

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

    private void CoolDownFunction()
    {
        if (coolDownTimer >= 0)
        {
            coolDownTimer -= Time.deltaTime;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.gameObject.tag == "GroundEnemy" && coolDownTimer <= 0)
        {
            CanTakeDamage();
            //coolDownTimer = coolDown;
        }
        if (collision.gameObject.tag == "Arrow")
        {
            health--;
            StartCoroutine(cameraShake.Shake(.05f, 1f));
            var sound = Instantiate(soundDamageTaken, transform.position, Quaternion.identity);
            Destroy(sound, 1);
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Hp_Pick_Up" && health < 5)
        {
            health = 1f + health;
            Debug.Log("Hello world");
            Destroy(collision.gameObject);
            var sound = Instantiate(soundPickup, transform.position, Quaternion.identity);
            Destroy(sound, 1);
        }
    }

    void CanTakeDamage()
    {
        {
            //coolDownTimer += coolDown;
            health--;
            StartCoroutine(cameraShake.Shake(.05f, 1f));
            var sound = Instantiate(soundDamageTaken, transform.position, Quaternion.identity);
            Destroy(sound, 1);
            coolDownTimer = coolDown;

            Debug.Log("Grogg bär sucks");
        }
    }
}


