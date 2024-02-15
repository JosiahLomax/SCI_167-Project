using UnityEngine;

//Code Written by Josiah Lomax
public class TroopIdleState : TroopBaseState
{
    public override void EnterState(TroopStateManager troop)
    {
        // Set Idle animation
        Debug.Log("We are in the Idle State!");
    }

   public override void UpdateState(TroopStateManager troop)
    {
        // Put idle functionality
        
        // In order to switch states: troop.SwitchState(troop.theStateBeingSwitchedTo);
    }

}
