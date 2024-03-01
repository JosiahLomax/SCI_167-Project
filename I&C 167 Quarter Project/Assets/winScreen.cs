using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winScreen : MainMenu
{
    // Start is called before the first frame update
    void Start()
    {
       new WaitForSeconds(5);
    }

    // Update is called once per frame
    void Update()
    {
        GameStateManager.GameOver();
    }
}
