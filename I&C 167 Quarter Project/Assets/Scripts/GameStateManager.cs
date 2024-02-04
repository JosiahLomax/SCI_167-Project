using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameStateManager : MonoBehaviour
{
    // makes it so we can grab it from anywhere
    public static GameStateManager Instance;


    enum GAMESTATE
    {
        MENU,
        PLAYING,
        PAUSED,
        GAMEOVER
        //others will be added later

    }

    private static GAMESTATE state;


    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            //here we can set if we want a starting life and stuff in the start
    
            DontDestroyOnLoad(Instance);
        }
        else
        {
            Destroy(this);
        }
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            GameStateManager.TogglePause();
        }
    }


    //not done
    public static void NewGame()
    {
        state = GAMESTATE.PLAYING;
        SceneManager.LoadScene(1);
    }


    public static void Resume()
    {
        state = GAMESTATE.PLAYING;
    }


    public static void GameOver()
    {
        // i might change this later to a diff scene for endgame result??
        state = GAMESTATE.MENU;
        SceneManager.LoadScene(0);
    }


    public static void TogglePause()
    {
        if (state == GAMESTATE.PLAYING)
        {
            state = GAMESTATE.PAUSED;
            Time.timeScale = 0;
        }
        else if(state == GAMESTATE.PAUSED)
        {
            state = GAMESTATE.PLAYING;
            Time.timeScale = 1;
        }
    }


    public static void ResetScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
}
