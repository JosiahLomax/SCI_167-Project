using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Code Written by Josiah Lomax
public class ArcherCombatP1 : MonoBehaviour
{
    [SerializeField]
    private Transform CombatRayCast;

    [SerializeField]
    private float bowRange;
    [SerializeField]
    private GameObject enemyTroop;

    private bool facingRight = true;
    private bool inRange = false;

    public ArcherTroopDetection archerTroopDetection;
    public Bow bowScript;
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
        RaycastHit2D hitTroop = Physics2D.Raycast(CombatRayCast.transform.position, facingRight ? Vector2.right : Vector2.left, bowRange, enemyTroopLayerP2);

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
            archerTroopDetection.StopMoveToTroop();
            bowScript.enabled = true;
        }
    }

    void StopAttack()
    {
        if(inRange == false)
        {
            bowScript.enabled = false;
        }
    }
        
}
