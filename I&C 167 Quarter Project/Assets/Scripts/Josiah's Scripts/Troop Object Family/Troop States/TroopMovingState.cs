using UnityEngine;

//Code Written by Josiah Lomax

public class TroopMovingState : TroopBaseState
{
    public override void EnterState(TroopStateManager troop)
    {
        // Set moving animation
        Debug.Log("We are in the Moving State!");
    }

    public override void UpdateState(TroopStateManager troop)
    {
        // Put troop's movement functionality here

        // In order to switch states: troop.SwitchState(troop.theStateBeingSwitchedTo);
    }
}
