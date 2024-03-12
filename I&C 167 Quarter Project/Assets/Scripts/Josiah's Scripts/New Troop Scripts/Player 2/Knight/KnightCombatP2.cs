using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Code Written by Josiah Lomax
public class KnightCombatP2 : MonoBehaviour
{
    [SerializeField]
    private Transform CombatRayCast;
    [SerializeField]
    private float combatRange;
    [SerializeField]
    private GameObject enemyTroop;


    private bool facingLeft = true;
    private bool inRange = false;

    public KnightState knightState;
    public TroopDetectionP2 troopDetection;

    public LayerMask enemyTroopLayerP1;


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
        RaycastHit2D hitTroop = Physics2D.Raycast(CombatRayCast.transform.position, facingLeft ? Vector2.left : Vector2.right, combatRange, enemyTroopLayerP1);

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
            troopDetection.StopMoveToTroop();
            // Set Attack animation and Deal Damage!
            Debug.Log("Player 2 Knight is in Swinging State!");
        }
    }
}
