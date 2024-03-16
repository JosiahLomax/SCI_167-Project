using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Code Written by Josiah Lomax
// This script will serve as the context for the Troop States
// Will create instances of Concrete Troop states

public class TroopStateManager : MonoBehaviour
{
    TroopBaseState currentState;                //Holds a reference to the active Troop State

    public TroopIdleState IdleState = new TroopIdleState();        // Instantiates the concrete Troop Idle State
    public TroopMovingState MovingState = new TroopMovingState();  // Instantiates the concrete Troop Moving State
    public TroopAttackingState AttackingState = new TroopAttackingState();  // Instantiates the concrete Troop Attacking State
    public TroopShootingState ShootingState = new TroopShootingState();    // Instantiates the concrete Troop Shooting State
    public TroopShieldingState ShieldingState = new TroopShieldingState(); // Instantiates the concrete Troop ShieldingState



    // Start is called before the first frame update
    void Start()
    {
        currentState = IdleState;

        currentState.EnterState(this);
    }

    // Update is called once per frame
    void Update()
    {
        currentState.UpdateState(this);
    }

    public void SwitchState(TroopBaseState state)
    {
        currentState = state;
        state.EnterState(this);
    }

}
