using UnityEngine;

//Code Written by Josiah Lomax
public class TroopAttackingState : TroopBaseState
{
    public override void EnterState(TroopStateManager troop)
    {
        //Set the attack animation
        Animator animator = troop.GetComponent<Animator>();         // Gets the animator controller on the troop
        animator.SetBool("isAttacking", true);                     // Sets the boolean for "isAttacking" to true within the animator controller
        animator.SetBool("isIdle", false);                        // Sets the boolean for "isIdle" to false within the animator controller
        animator.SetBool("isMoving", false);                      // Sets thhe booolean for "isMoving" to false within the animator controller

        Debug.Log("We are in the Attacking State!");

    }

    public override void UpdateState(TroopStateManager troop)
    {
        // Put the Troop's attacking functionality here

        // In order to switch states: troop.SwitchState(troop.theStateBeingSwitchedTo);
    }
}
