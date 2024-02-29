using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// child class of AIEnemy 
public class AIknight : AIEnemy
{
    protected override void MoveTowardTarget()
    {
        base.MoveTowardTarget();// may change
        transform.Translate(Vector3.forward * movementSpeed * Time.deltaTime);
    }

    protected override void AttackTarget()
    {
        //knight does 2 damage but more hp
    }

}
