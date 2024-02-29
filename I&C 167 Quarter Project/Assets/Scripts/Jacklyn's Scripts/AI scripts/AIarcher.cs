using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// child class of AIEnemy
public class AIarcher : AIEnemy
{
    protected override void MoveTowardTarget()
    {
        //base.MoveTowardTarget();

        //movementSpeed/2 so they walk slower than knights idk lol
        transform.Translate(Vector3.forward * (movementSpeed / 2) * Time.deltaTime);

    }

    protected override void AttackTarget()
    {
        // archer does 3 damamge but low hp
    }
}
