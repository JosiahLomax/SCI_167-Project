using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIstateMachine : MonoBehaviour //made by jacklyn
{
    [SerializeField]
    private KnightState knightState;
    [SerializeField]
    private ArcherState archerState;
    [SerializeField]
    private float detectionRange;
    [SerializeField]
    private LayerMask enemyLayer;

    

    void Start()
    {
        knightState = KnightState.Walking;
        archerState = ArcherState.Walking;
    }
    void Update()
    {
        if (knightState == KnightState.Walking)
        {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.left, detectionRange, enemyLayer);
            if (hit.collider != null) //if raycast finds enemy layer (not null/empty), change states
            {
                knightState = KnightState.Attacking;
            }
        }

    }

    public enum KnightState
    {
        Idle,
        Walking,
        Attacking
    };

    public enum ArcherState
    {
        Idle,
        Walking,
        Shooting
    };

    public enum ShielderState
    {
        Idle,
        Walking,
        Attacking
    };

    public enum MageState
    {
        Idle,
        Walking,
        Shooting
    };

    public enum GoblinState
    {
        Idle,
        Walking,
        Attacking
    };
}
