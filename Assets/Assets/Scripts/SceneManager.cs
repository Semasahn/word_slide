using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{
    public void playButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }

    public void backButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }

    public void gameOver()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(3);
    }

    public void rulesButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(2);

    }

    public void restartButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }

    public void exitButton()
    {
        Application.Quit();
    }

   
}
