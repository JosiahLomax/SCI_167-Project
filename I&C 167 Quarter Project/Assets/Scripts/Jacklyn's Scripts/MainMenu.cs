//Jacklyn's Script
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    // will be used to show help button
    //public void Help()
    //{
    //    SceneManager.LoadScene(5);
    //}
    public void QuitGame()
    {
        Application.Quit();
    }
}
