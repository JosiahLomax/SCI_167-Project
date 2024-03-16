using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Code Written by Josiah Lomax
public class KnightCombat : MonoBehaviour
{


    [SerializeField]
    private Transform CombatRayCast;                    // References the CombatRayCast on the Knight prefab

    [SerializeField]
    private float combatRange;                          // The range that the Player 1 Knight will begin attacking in
    [SerializeField]
    private GameObject enemyTroop;
    

    private bool facingRight = true;
    private bool inRange = false;

   
    public KnightState knightState;                      // References the P1Knight State Machine script on the Knight prefab
    public TroopDetection troopDetection;               // References the TroopDetection script on the Knight prefab
    public Animator knightAnimator;
    public LayerMask enemyTroopLayerP2;                 // enemyTroopLayerP2 is the layer that all player 2 troops should be under






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
        RaycastHit2D hitTroop = Physics2D.Raycast(CombatRayCast.transform.position, facingRight ? Vector2.right : Vector2.left, combatRange, enemyTroopLayerP2);            // Creates a raycast at the point of the CombatRaycast object on the Knight prefab, with the length of the combat range. It looks for anything on the enemyTroopLayerP2 layer

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
            troopDetection.StopMoveToTroop();               // Goes into the TroopDetection script, and calls the StopMoveToTroop function. 
            knightAnimator.SetBool("isAttacking", true);  // Sets Attack Animation! 
        }
        
    }

    void StopAttack()
    {
        if (inRange == false)
        {
            knightAnimator.SetBool("isAttacking", false);           // Should stop the Attack Animation!
        }
    }

   


}
