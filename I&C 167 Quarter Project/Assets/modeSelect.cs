using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class modeSelect : MonoBehaviour
{
    public void comMode()
    {
        GameStateManager.NewGameCom();
    }

    public void p2Mode()
    {
        GameStateManager.NewGameP2();
    }
}
