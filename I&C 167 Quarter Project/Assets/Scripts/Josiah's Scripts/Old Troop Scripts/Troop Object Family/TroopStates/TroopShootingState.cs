using UnityEngine;

//Code Written by Josiah Lomax
public class TroopShootingState : TroopBaseState
{
    public override void EnterState(TroopStateManager troop)
    {
        //Set the shooting animation
        Animator animator = troop.GetComponent<Animator>();         // Gets the animator controller on the troop
        animator.SetBool("isShooting", true);                      // Sets the boolean for "isShooting" to true within the animator controller
        animator.SetBool("isIdle", false);                        // Sets the boolean for "isIdle" to false within the animator controller
        animator.SetBool("isMoving", false);                     // Sets the boolean for "isMoving" to false within the animator controller
        Debug.Log("We are in the Shooting State!");
    }

    public override void UpdateState(TroopStateManager troop)
    {
        // Put the Troop's shooting functionality here

        // In order to switch states: troop.SwitchState(troop.theStateBeingSwitchedTo);
    }

}
