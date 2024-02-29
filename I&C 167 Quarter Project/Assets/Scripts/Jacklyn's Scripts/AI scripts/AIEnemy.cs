using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// PARENT CLASS FOR AI ENEMY
public class AIEnemy : MonoBehaviour   // coded by Jacklyn
{
    public Transform target; //target will be player's troops/tower
    public float movementSpeed; //used for all types of troops
   
    protected virtual void Start()
    {
        MoveTowardTarget();
    }

    protected virtual void Update()
    {
        
    }

    protected virtual void MoveTowardTarget()
    {

    }

    protected virtual void AttackTarget()
    {

    }
}
