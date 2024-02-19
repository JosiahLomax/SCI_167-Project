using UnityEngine;

//Code Written by Josiah Lomax
public class TroopShieldingState : TroopBaseState
{
    public override void EnterState(TroopStateManager troop)
    {
        //Set the shielding animation here
        Animator animator = troop.GetComponent<Animator>();     // Gets the animator controller on the troop
        Debug.Log("We are in the Shielding State!");
    }

    public override void UpdateState(TroopStateManager troop)
    {
        //Put Troop shielding functionality here

       // In order to switch states: troop.SwitchState(troop.theStateBeingSwitchedTo);
    }

}
