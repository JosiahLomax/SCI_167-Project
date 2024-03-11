using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Code Written by Josiah Lomax, Sho 
public class P1KnightStateMachine : MonoBehaviour
{
    public KnightState knightState;

    public LayerMask enemyTroopLayerP2;

    // Start is called before the first frame update
    void Start()
    {
        Idle();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Idle()
    {
        knightState = KnightState.Idle;
        Debug.Log("Knight is in Idle State!");
    }

    public void Swinging()
    {
        Debug.Log("Knight is in Attacking State!");
    }
    public enum KnightState
    {
        Idle,
        Walking,
        Swinging
    }
}
