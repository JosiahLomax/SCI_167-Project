using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        // unless we want to have different levels later on then ill add this
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex * 1);
        // HELLO IS THIS WORKING??

        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
