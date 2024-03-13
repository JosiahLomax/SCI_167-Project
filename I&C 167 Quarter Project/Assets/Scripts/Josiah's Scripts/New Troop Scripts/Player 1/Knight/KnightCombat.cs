using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Code Written by Josiah Lomax
public class KnightCombat : MonoBehaviour
{


    [SerializeField]
    private Transform CombatRayCast;

    [SerializeField]
    private float combatRange;
    [SerializeField]
    private GameObject enemyTroop;
    

    private bool facingRight = true;
    private bool inRange = false;

   
    public KnightState knightState;
    public TroopDetection troopDetection;
    public Animator knightAnimator;
    public LayerMask enemyTroopLayerP2;
 





    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckForTroop();
    }

    void CheckForTroop()
    {
        RaycastHit2D hitTroop = Physics2D.Raycast(CombatRayCast.transform.position, facingRight ? Vector2.right : Vector2.left, combatRange, enemyTroopLayerP2);

        if (hitTroop.collider == true)
        {
            inRange = true;
            Attack();

        }
        else if (hitTroop.collider == false)
        {
            inRange = false;
            StopAttack();
        }
        

    }

   

    void Attack()
    {
        if(inRange == true)
        {
            troopDetection.StopMoveToTroop();
            knightAnimator.SetBool("isAttacking", true);  // Sets Attack Animation! 
        }
        
    }

    void StopAttack()
    {
        if (inRange == false)
        {
            knightAnimator.SetBool("isAttacking", false);
        }
    }

   


}
