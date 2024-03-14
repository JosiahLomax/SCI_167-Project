using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Code Written by Josiah Lomax
public class ArcherCombatP2 : MonoBehaviour
{
    [SerializeField]
    private Transform CombatRayCast;

    [SerializeField]
    private float bowRange;
    [SerializeField]
    private GameObject enemyTroop;

    private bool facingLeft = true;
    private bool inRange = false;

    public ArcherTroopDetectionP2 archerTroopDetectionP2;
    public Bow bowScript;
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
        RaycastHit2D hitTroop = Physics2D.Raycast(CombatRayCast.transform.position, facingLeft ? Vector2.left : Vector2.right, bowRange, enemyTroopLayerP1);

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
            archerTroopDetectionP2.StopMoveToTroop();
            bowScript.enabled = true;
        }
    }

    void StopAttack()
    {
        if (inRange == false)
        {
            bowScript.enabled = false;
        }
    }
}
