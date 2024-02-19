using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

//Code Written by Josiah Lomax

public class TroopMovingState : TroopBaseState
{
   
    public override void EnterState(TroopStateManager troop)
    {
        TroopAI Ai = troop.GetComponent<TroopAI>();             // Not sure how we would go about calling the troop Ai script within this one so that when the troop moves they enter the moving state
       
        // Set moving animation
        Animator animator = troop.GetComponent<Animator>();  // Gets the animator controller on the troop
        animator.SetBool("isMoving", true);                 // Sets the boolean for "isMoving" within the animator controller to true
        animator.SetBool("isAttacking", false);            // Sets the boolean for "isAttacking" within the animator controller to false
        animator.SetBool("isIdle", false);                 // Sets the boolean for "isIdle" within the animator controller to false
        Debug.Log("We are in the Moving State!");           
    }

    public override void UpdateState(TroopStateManager troop)
    {
        // Put troop's movement functionality here
       
    }


    // In order to switch states: troop.SwitchState(troop.theStateBeingSwitchedTo);
}

