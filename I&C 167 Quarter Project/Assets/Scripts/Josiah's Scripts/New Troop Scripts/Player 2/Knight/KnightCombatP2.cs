using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Code Written by Josiah Lomax
public class KnightCombatP2 : MonoBehaviour
{
    [SerializeField]
    private Transform CombatRayCast;                     // References the CombatRayCast on the Player 2 Knight prefab
    [SerializeField]
    private float combatRange;                           // The range that the Player 2 Knight will begin attacking in
    [SerializeField]
    private GameObject enemyTroop;


    private bool facingLeft = true;
    private bool inRange = false;

    public KnightState knightState;                      // References the Knight State Machine script on the Knight prefab
    public Animator knightAnimator;
    public TroopDetectionP2 troopDetection;             // References the TroopDetectionP2 script on the Player 2 Knight prefab

    public LayerMask enemyTroopLayerP1;                 // enemyTroopLayerP1 is the layer that all player 1 troops should be under


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
        RaycastHit2D hitTroop = Physics2D.Raycast(CombatRayCast.transform.position, facingLeft ? Vector2.left : Vector2.right, combatRange, enemyTroopLayerP1);      // Creates a raycast at the point of the CombatRaycast object on the Player 2 Knight prefab, with the length of the combat range. It looks for anything on the enemyTroopLayerP1 layer

        if (hitTroop.collider == true)
        {
            inRange = true;
            Attack();

        }
        else if (hitTroop.collider == false)
        {
            inRange = false;
        }

    }

    void Attack()
    {
        if (inRange == true)
        {
            troopDetection.StopMoveToTroop();                // Goes into the TroopDetectionP2 script, and calls the StopMoveToTroop function. 
            // Sets Attack animation 
            knightAnimator.SetBool("isAttacking", true);
            Debug.Log("Player 2 Knight is in Swinging State!");
        }
    }

    void StopAttack()
    {
        if (inRange == false)
        {
            knightAnimator.SetBool("isAttacking", false);   // Stops the Attack Animation!
        }
    }
}
