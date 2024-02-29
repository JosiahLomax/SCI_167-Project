//Jacklyn's Script
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    
    public GameObject pauseMenu;

    public bool isPaused;

    void Start()
    {
        pauseMenu.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                TogglePauseMenu();
            }
        }
    }

    public void TogglePauseMenu()
    {
        pauseMenu.SetActive(true);
        //GameStateManager.TogglePause();
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        //GameStateManager.Resume();
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void RestartLevel()
    {
        Time.timeScale = 1f;
        
        GameStateManager.ResetScene();
    }

    public void GoToMainMenu()
    {
        //GameStateManager.TogglePause();
        GameStateManager.GameOver();
    }
}
