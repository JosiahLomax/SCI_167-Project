using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MageCombatP1 : MonoBehaviour
{
    [SerializeField]
    private Transform CombatRayCast;                                // This is a raycast object on the Mage prefab itself

    [SerializeField]
    private float staffRange;                                        // The range before the Staff script is called
    [SerializeField]
    private GameObject enemyTroop;

    private bool facingRight = true;
    private bool inRange = false;

    public ArcherTroopDetection archerTroopDetection;              // Reference to the ArcherTroopDetection Script
    public Staff staffScript;                                          // Reference to the Staff script
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
        RaycastHit2D hitTroop = Physics2D.Raycast(CombatRayCast.transform.position, facingRight ? Vector2.right : Vector2.left, staffRange, enemyTroopLayerP2);               // Creates a raycast at the point where the combat raycast is, and is the length of the Staff range. It looks for anything on the enemyTroopLayerP2

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
        if (inRange == true)
        {
            archerTroopDetection.StopMoveToTroop();                     // Goes into the archerTroopDetection script, and calls the function that stops the Mage's movement to an enemy troop
            staffScript.enabled = true;                                  // Enables the Staff script on the Mage prefab, which acts as the shooting of a Spell
        }
    }

    void StopAttack()
    {
        if (inRange == false)
        {
            staffScript.enabled = false;                              // Disables the Staff script on the Mage prefab, meaning it should no longer be shooting Spells
        }
    }

}
