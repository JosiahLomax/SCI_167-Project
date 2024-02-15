using UnityEngine;

//Code Written by Josiah Lomax

public class TroopAttackingState : TroopBaseState
{
    public override void EnterState(TroopStateManager troop)
    {
        //Set the attack animation
        Debug.Log("We are in the Attacking State!");
    }

    public override void UpdateState(TroopStateManager troop)
    {
        // Put the Troop's attacking functionality here

        // In order to switch states: troop.SwitchState(troop.theStateBeingSwitchedTo);
    }
}
