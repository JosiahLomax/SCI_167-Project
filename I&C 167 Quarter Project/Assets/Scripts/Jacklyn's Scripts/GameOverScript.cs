using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScript : MonoBehaviour
{
    public GameObject gameOverScreen;
    public GameObject p1WinScreen;
    public GameObject p2WinScreen;

    public void ShowGameOver()
    {
        gameOverScreen.SetActive(true);
        p1WinScreen.SetActive(false);
        p2WinScreen.SetActive(false);
    }
    public void Showp1WinScreen()
    {
        gameOverScreen.SetActive(false);
        p1WinScreen.SetActive(true);
        p2WinScreen.SetActive(false);
    }
    public void Showp2WinScreen()
    {
        gameOverScreen.SetActive(false);
        p1WinScreen.SetActive(false);
        p2WinScreen.SetActive(true);
    }
}
