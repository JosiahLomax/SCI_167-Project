using UnityEngine;

//Code Written by Josiah Lomax
// This script serves as a "prototype" class for the concrete states
// Will set/define methods used in the concrete states
//Type of the current state variable in the context

public abstract class TroopBaseState
{
  public abstract void EnterState(TroopStateManager troop);

  public abstract void UpdateState(TroopStateManager troop);

    
}

//In order to create another troop state, simply create a class and have it derive from this base state

