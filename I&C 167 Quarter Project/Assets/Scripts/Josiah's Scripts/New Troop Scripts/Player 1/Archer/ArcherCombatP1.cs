using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Code Written by Josiah Lomax
public class ArcherCombatP1 : MonoBehaviour
{
    [SerializeField]
    private Transform CombatRayCast;                                // This is a raycast object on the Archer prefab itself

    [SerializeField]
    private float bowRange;                                        // The range before the bow script is called
    [SerializeField]
    private GameObject enemyTroop;

    private bool facingRight = true;
    private bool inRange = false;

    public ArcherTroopDetection archerTroopDetection;              // Reference to the ArcherTroopDetection Script
    public Bow bowScript;                                          // Reference to the Bow script
    public LayerMask enemyTroopLayerP2;                            // enemyTroopLayerP2 is the layer that all player 2 troops should be under

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
        RaycastHit2D hitTroop = Physics2D.Raycast(CombatRayCast.transform.position, facingRight ? Vector2.right : Vector2.left, bowRange, enemyTroopLayerP2);               // Creates a raycast at the point where the combat raycast is, and is the length of the bow range. It looks for anything on the enemyTroopLayerP2

        if(hitTroop.collider == true)
        {
            inRange = true;
            Attack();
        }
        else if(hitTroop.collider == false)
        {
            inRange = false;
            StopAttack();
        }
    }

    void Attack()
    {
        if(inRange == true)
        {
            archerTroopDetection.StopMoveToTroop();                     // Goes into the archerTroopDetection script, and calls the function that stops the Archer's movement to an enemy troop
            bowScript.enabled = true;                                  // Enables the bow script on the Archer prefab, which acts as the shooting of an arrow
        }
    }

    void StopAttack()
    {
        if(inRange == false)
        {
            bowScript.enabled = false;                              // Disables the bow script on the Archer prefab, meaning it should no longer be shooting arrows
        }
    }
        
}
