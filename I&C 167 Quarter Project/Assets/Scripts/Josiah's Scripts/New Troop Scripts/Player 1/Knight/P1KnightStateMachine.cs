using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Code Written by Josiah Lomax, Sho 
public class P1KnightStateMachine : MonoBehaviour
{
    public KnightState knightState;             // References the KnightState Script

    public LayerMask enemyTroopLayerP2;          // The layer all player 2 troops should be under

    // Start is called before the first frame update
    void Start()
    {
        Idle();                             // Immediatley calls the Idle function
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Idle()
    {
        knightState = KnightState.Idle;                         // Sets the Player 1 Knight's state to idle
        Debug.Log("Knight is in Idle State!");
    }

    public void Swinging()
    {
        Debug.Log("Knight is in Attacking State!");                 // Should set the Player 1Knight's state to swinging when it begins to attack
    }
    public enum KnightState                                     // A list of the three different states the Knight has
    {
        Idle,
        Walking,
        Swinging
    }
}
