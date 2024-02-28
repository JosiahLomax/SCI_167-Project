using UnityEngine;

//Code Written by Josiah Lomax
public class TroopIdleState : TroopBaseState
{
    public override void EnterState(TroopStateManager troop)
    {
        // Set Idle animation
        Animator animator = troop.GetComponent<Animator>();     // Gets the animator controller on the troop
        animator.SetBool("isIdle", true);                      // Sets the boolean of "isIdle" to true within the animator controller
        animator.SetBool("isMoving", false);                  // Sets the boolean of "isMoving" to false within the animator controller
        animator.SetBool("isAttacking", false);              // Depending on if "isAttacking" is a bool within the specific troop's animator controller, it will be set to false
        animator.SetBool("isShooting", false);               // Depending on if "isShooting" is a bool within the specific troop's animator controller, it will be set to false
        Debug.Log("We are in the Idle State!");
    }

    public override void UpdateState(TroopStateManager troop)
    {
        // Put idle functionality

        // In order to switch states: troop.SwitchState(troop.theStateBeingSwitchedTo);
    }
}
