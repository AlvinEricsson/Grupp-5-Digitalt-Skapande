using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void StartGame(string gameLevel)
    {
        SceneManager.LoadScene(gameLevel);
    }

    public void ExitGameButton()
    {
        Application.Quit();
    }

    public void HowToPlayButton()
    {
        SceneManager.LoadScene("HowToPlayMenu");
    }

    public void LoadScene()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
