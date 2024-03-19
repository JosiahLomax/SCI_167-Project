// Jacklyn's Script
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameStateManager : MonoBehaviour
{
    // makes it so we can grab it from anywhere
    public static GameStateManager Instance;
    //public static GameOverScript gameOverScript;


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

    //not done
    public static void NewGameCom()
    {
        state = GAMESTATE.PLAYING;
        SceneManager.LoadScene(3);
        Time.timeScale = 1f;
    }

    public static void NewGameP2()
    {
        state = GAMESTATE.PLAYING;
        SceneManager.LoadScene(2);
        Time.timeScale = 1f;
    }


    public static void Resume()
    {
        state = GAMESTATE.PLAYING;
    }


    //public static void GameOverWin()
    //{
    //    // will show game over scene
    //    state = GAMESTATE.GAMEOVER;
    //    gameOverScript.Showp1WinScreen();
    //}

    public static void GameOver()
    {
        state = GAMESTATE.GAMEOVER;
        SceneManager.LoadScene(4);
    }


   


    public static void ResetScene()
    {
        state = GAMESTATE.PLAYING;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
}
