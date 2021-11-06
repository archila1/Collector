using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void StartGame1()
    {
        SceneManager.LoadScene("Game1");
    }

    public void StartGame2()
    {
        SceneManager.LoadScene("Game2");
    }

    public void Quit()
    {
        Application.Quit();
    }

}
